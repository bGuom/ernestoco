FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["ASPNET_Core_2_1/ASPNET_Core_2_1.csproj", "ASPNET_Core_2_1/"]
RUN dotnet restore "ASPNET_Core_2_1/ASPNET_Core_2_1.csproj"
COPY . .
WORKDIR "/src/ASPNET_Core_2_1"
RUN dotnet build "ASPNET_Core_2_1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ASPNET_Core_2_1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ASPNET_Core_2_1.dll"]