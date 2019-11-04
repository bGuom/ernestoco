FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
FROM mcr.microsoft.com/dotnet/core/runtime:2.2
WORKDIR /app
COPY public/ app/
ENTRYPOINT ["dotnet", "app/ASPNET_Core_2_1.dll"]