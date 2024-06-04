#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV DB_CONNECTION_STRING="Server=192.168.18.11,1433;Database=USUARIOS;User Id=sa;Password=Xark300*;TrustServerCertificate=True;"

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["proy_web_api/proy_web_api.csproj", "proy_web_api/"]
RUN dotnet restore "./proy_web_api/proy_web_api.csproj"
COPY . .
WORKDIR "/src/proy_web_api"
RUN dotnet build "./proy_web_api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./proy_web_api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "proy_web_api.dll"]