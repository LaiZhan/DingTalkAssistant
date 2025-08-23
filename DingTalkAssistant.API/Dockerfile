FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER 1000
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DingTalkAssistant.API/DingTalkAssistant.API.csproj", "DingTalkAssistant.API/"]
RUN dotnet restore "DingTalkAssistant.API/DingTalkAssistant.API.csproj"
COPY . .
WORKDIR "/src/DingTalkAssistant.API"
RUN dotnet build "./DingTalkAssistant.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DingTalkAssistant.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish --self-contained false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DingTalkAssistant.API.dll"]