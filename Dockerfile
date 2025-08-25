# Stage 1: Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Stage 2: Build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the solution file and restore dependencies
COPY ["DingTalkAssistant.sln", "./"]

# Copy all project files and build
COPY . .
RUN dotnet restore "DingTalkAssistant.sln"
RUN dotnet build "DingTalkAssistant.sln" -c $BUILD_CONFIGURATION --no-restore

# Publish the API project
RUN dotnet publish "DingTalkAssistant.API/DingTalkAssistant.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish --self-contained false --no-restore

# Stage 3: Final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DingTalkAssistant.API.dll"]