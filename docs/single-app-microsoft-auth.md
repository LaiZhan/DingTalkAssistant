# 单一 Azure AD (Entra ID) Application 统一支持 后端 + SPA 登录方案
> https://developer.microsoft.com/en-us/microsoft-365/profile


> 目标：只注册 **一个** 应用（App Registration），同时满足：
> 1. 服务器端（后端 / 管理页）使用 Cookie 会话登录
> 2. 前后端分离 SPA 使用 Access Token (Bearer) 调你的受保护 API
> 3. 可扩展（自定义 scope / 角色）、仅你本人可用的限制可选

---
## 总览流程图（逻辑）
```
浏览器(后端页) ──跳转OIDC──▶ Microsoft 登录
      ▲                              │
      │  回调(授权码)                │验证+授权
      │                              ▼
 Cookie 会话 ◀──交换 tokens── Web 后端（拿到 id_token + access_token[api.read]）

SPA ──loginRedirect(PKCE+scope api.read)──▶ Microsoft 登录
  ▲                                        │
  │<─回调(access_token/id_token)───────────┘
  │
  └──Authorization: Bearer <access_token>──▶ 统一 API (JwtBearer 验证)
```

---
## 执行清单（Step by Step）
| 序号 | 步骤 | 说明 |
|------|------|------|
| 1 | 注册单一应用 | 支持 Web + SPA 回调 |
| 2 | 配置多个 Redirect URI | Web: `/signin-oidc`；SPA: `/auth/callback` |
| 3 | Expose an API 定义自有 scope | 例如 `api.read` (全名 `api://<clientId>/api.read`) |
| 4 | 生成 Client Secret | 仅服务器 (机密客户端) 使用 |
| 5 | OIDC Cookie 登录配置 | 后端使用 `AddOpenIdConnect + AddCookie` |
| 6 | JWT 保护 API | `AddJwtBearer` 使用同一 Authority；ValidAudiences 包含 ClientId + ApplicationIdUri |
| 7 | SPA 使用 msal-browser | Auth Code PKCE 获取 access_token (scope = 自定义 scope) |
| 8 | CORS | 限定前端域名；允许 `Authorization` 头 |
| 9 | 可选邮箱白名单 | 限制仅你个人账号 |
| 10 | 测试 & 故障排查 | 401/403 分析 aud/scope/issuer |

---
## 1. 注册单一应用
Azure Portal → Entra ID → App registrations → *New registration*
- Name: `MyUnifiedApp`
- Supported account types: *Accounts in any org directory and personal Microsoft accounts* (common)
- Redirect URI (初始只加 Web)：`https://localhost:5001/signin-oidc`
- Register 后记录：`Client ID`、`Directory (Tenant) ID`

> 若只你自己使用，后续可以把 TenantId 从 `common` 改成真实租户 GUID 提升安全性。

---
## 2. 增加 SPA 平台 & 回调
应用 → Authentication：
- Add a platform → *Single-page application*
  - Redirect URI: `http://localhost:5173/auth/callback`（按前端端口改）
- *Front-channel logout URL*（可选）：`https://localhost:5001/signout-oidc`
- 如看到 *Allow public client flows* / *Enable the following mobile and desktop flows*，一般可保持默认；仅 msal 需要交互式授权即可。

---
## 3. 暴露 API & Scope
应用 → Expose an API：
1. *Set Application ID URI*：默认 `api://<clientId>`（可自定义，但保持简单）
2. *Add a scope*：
   - Scope name: `api.read`
   - Admin/User consent 描述自填
   - 结果：`api://<clientId>/api.read`
3. （可选后期）再添加 `api.write` 等。

---
## 4. 生成 Client Secret
Certificates & secrets → *New client secret* → 复制 **Value**（仅显示一次）。
- 生产中放环境变量 / KeyVault，不提交仓库。

---
## 5. 配置（逻辑结构示例）
`appsettings.json` （占位示例）
```json
"AzureAd": {
  "Instance": "https://login.microsoftonline.com/",
  "TenantId": "common",              // 或真实租户 GUID
  "ClientId": "YOUR_CLIENT_ID",
  "ClientSecret": "<ENV OR USER-SECRETS>",
  "CallbackPath": "/signin-oidc",
  "ApplicationIdUri": "api://YOUR_CLIENT_ID",
  "Scopes": "api://YOUR_CLIENT_ID/api.read"
}
```

### Program.cs 核心伪代码
```csharp
builder.Services.AddAuthentication(options => {
    options.DefaultScheme = "Cookies";              // 浏览器页使用 Cookie
    options.DefaultChallengeScheme = "Oidc";        // 触发 OIDC 登录
})
.AddCookie("Cookies")
.AddOpenIdConnect("Oidc", o => {
    var cfg = builder.Configuration.GetSection("AzureAd");
    o.ClientId = cfg["ClientId"];
    o.ClientSecret = cfg["ClientSecret"];          // 仅后端使用
    o.Authority = cfg["Instance"] + cfg["TenantId"] + "/v2.0";
    o.ResponseType = "code";                       // Auth Code + PKCE（框架自动）
    o.SaveTokens = true;                            // 把 tokens 放到认证票据中
    o.CallbackPath = cfg["CallbackPath"];
    o.Scope.Clear();
    o.Scope.Add("openid"); o.Scope.Add("profile"); o.Scope.Add("email");
    o.Scope.Add(cfg["Scopes"]);                    // 请求自定义 API scope
});

builder.Services.AddAuthentication()
    .AddJwtBearer("Bearer", o => {
        var cfg = builder.Configuration.GetSection("AzureAd");
        o.Authority = cfg["Instance"] + cfg["TenantId"] + "/v2.0";
        // 有的 token aud = clientId，有的 = ApplicationIdUri，二者都认可
        o.TokenValidationParameters.ValidAudiences = new [] {
            cfg["ClientId"], cfg["ApplicationIdUri"]
        };
    });

builder.Services.AddAuthorization(opt => {
    opt.AddPolicy("MeOnly", p => p.RequireAssertion(ctx =>
        ctx.User.HasClaim(c => (c.Type == "preferred_username" || c.Type == "email") &&
            c.Value.Equals("you@outlook.com", StringComparison.OrdinalIgnoreCase))));
});
```

### 控制器授权粒度
```csharp
// 仅 Cookie 交互页面
[Authorize(AuthenticationSchemes = "Cookies")]
public class AdminController : Controller { }

// 仅 API (SPA 调用)
[Authorize(AuthenticationSchemes = "Bearer")]
[Route("api/[controller]")]
public class DataController : ControllerBase { }

// 任意方式（Cookie 或 Bearer）都可
[Authorize]
public class HybridController : ControllerBase { }
```

---
## 6. SPA 集成 (msal-browser)
安装：
```bash
npm install @azure/msal-browser
```
初始化：
```ts
import { PublicClientApplication } from '@azure/msal-browser';

const msal = new PublicClientApplication({
  auth: {
    clientId: 'YOUR_CLIENT_ID',
    authority: 'https://login.microsoftonline.com/common',
    redirectUri: 'http://localhost:5173/auth/callback'
  },
  cache: { cacheLocation: 'sessionStorage' }
});

export function login() {
  return msal.loginRedirect({
    scopes: ['openid','profile','email','api://YOUR_CLIENT_ID/api.read']
  });
}

export async function getToken() {
  const account = msal.getAllAccounts()[0];
  if (!account) throw new Error('Not logged in');
  return msal.acquireTokenSilent({
    account,
    scopes: ['api://YOUR_CLIENT_ID/api.read']
  });
}
```
调用 API：
```ts
const { accessToken } = await getToken();
fetch('https://localhost:5001/api/data', {
  headers: { Authorization: `Bearer ${accessToken}` }
});
```

---
## 7. CORS 设置
- 允许来源：`http://localhost:5173` 和生产域名
- 允许头：`Authorization, Content-Type`
- 允许方法：`GET,POST,PUT,DELETE,OPTIONS`
- 返回前端前，加 `Access-Control-Allow-Credentials: true` 仅当你需要跨域携带 Cookie（SPA 场景下调用 Bearer Token 一般不需要 Cookie）。

---
## 8. 限制仅你本人使用（可选）
在策略或中间件中检查：
```csharp
var email = User.FindFirst("preferred_username")?.Value ?? User.FindFirst("email")?.Value;
if (!string.Equals(email, "you@outlook.com", StringComparison.OrdinalIgnoreCase)) return Forbid();
```

---
## 9. 测试用例矩阵
| 场景 | 期望 | 排查点 |
|------|------|--------|
| 未登录访问 Cookie 页 | 302 跳转微软登录 | Challenge 方案是否设为 Oidc |
| SPA 未登录调用 API | 401 | JwtBearer 正常，CORS 不应吞异常 |
| 登录后访问 API | 200 | token aud & scope 正确 |
| 去掉 scope 请求 | token 不含自定义 scope | 前端请求是否缺少 scope 参数 |
| 更换别的微软账号 | 403 (启用 MeOnly) | email claim 匹配失败 |

---
## 10. 常见错误速查
| 错误 | 可能原因 | 解决 |
|------|----------|------|
| AADSTS650053 / insufficient_scope | scope 未在授权时请求 | 登录时加入自定义 scope |
| invalid_audience | ValidAudiences 未包含实际 aud | 加入 clientId 或 ApplicationIdUri |
| login loop | Cookies 与 OIDC Scheme 混淆 | 检查 DefaultScheme / ChallengeScheme |
| acquireTokenSilent 失败 | 缓存无账号或 scope 改变 | 重新 loginRedirect |

---
## 11. 安全最佳实践
- 生产将 `TenantId` 固定为你的租户 GUID 而不是 `common`
- Secret 不入库；使用 User Secrets / 环境变量
- Access Token 不入 localStorage；优先 sessionStorage / 内存
- 严格 CORS + HTTPS
- 最小化 scope；不需要 Graph 就不要加 `User.Read`（或独立一次获取）

---
## 12. 后期扩展路线
| 需求 | 做法 |
|------|------|
| 添加写操作权限 | 新增 scope `api.write`，前端按需请求；后端策略检查 `scp` 包含 api.write |
| 角色/分级 | Manifest 添加 `appRoles`，前端请求 `roles`，后端 `[Authorize(Roles="Admin")]` |
| 调 Microsoft Graph | 登录或 silent 时再请求 `User.Read` scope；后端可用 On-Behalf-Of |
| 切换多环境 | 使用不同 Redirect URI + 不同 appsettings.*.json |

---
## 一页速记（粘贴到内部文档）
- ClientId = <记录>
- ApplicationIdUri = `api://<ClientId>`
- Scope = `api://<ClientId>/api.read`
- Authority = `https://login.microsoftonline.com/common/v2.0`
- Web 回调：`/signin-oidc`
- SPA 回调：`/auth/callback`
- 后端认证：Cookie(OIDC) + JwtBearer(同 Authority，不同 Scheme)
- SPA：msal-browser Auth Code PKCE + scope -> Bearer 调 API
- 限制本人：策略检查邮箱 claim

---
**完成后验证**：
1. 访问受保护 API 无 token → 401
2. SPA 登录后携带 token → 200
3. 后端管理页自动跳转登录
4. 其它账号 → 403 (若开启白名单)

---
如需：
- Program.cs 完整模板
- msal 错误追踪清单
- 多环境 secrets 管理建议
随时再问。
