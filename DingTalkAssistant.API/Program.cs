using DingTalkAssistant.API.Models;
using DingTalkAssistant.API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DingTalkAssistant.API", Version = "v1" });
});

builder.Services.Configure<DingTalkConfig>(builder.Configuration.GetSection("DingTalk"));

builder.Services.AddScoped<IDingTalkService, DingTalkService>();
builder.Services.AddScoped<INewDingTalkService, NewDingTalkService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DingTalkAssistant.API v1"));
}

app.UseAuthorization();

app.MapControllers();

app.Run();