# Stage 1: Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
# Create a non-root user for security (best practice for Aliyun/cloud)
USER 1000
WORKDIR /app
# Expose the port your application listens on (confirm this is 8080)
EXPOSE 8080

# Stage 2: Build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
# Optimal cache layer: copy project files first
COPY ["DingTalkAssistant.API.csproj", "./"]
RUN dotnet restore "DingTalkAssistant.API.csproj"
# Copy everything else and build
COPY . .
RUN dotnet build "DingTalkAssistant.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Stage 3: Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DingTalkAssistant.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish --self-contained false --no-restore

# Stage 4: Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DingTalkAssistant.API.dll"]