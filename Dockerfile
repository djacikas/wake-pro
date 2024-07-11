#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Build and run the project (run from solution directory):
# Create image: docker build -t wakeproapi .
# Run image: docker run -d --name wakeproapi -p 8080:8080 wakeproapi

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WakeProApi/WakeProApi.csproj", "WakeProApi/"]
RUN dotnet restore "WakeProApi/WakeProApi.csproj"
COPY . .
WORKDIR "/src/WakeProApi"
RUN dotnet build "WakeProApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WakeProApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WakeProApi.dll"]
