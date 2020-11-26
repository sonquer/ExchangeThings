FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY Services/ExchangeThings.WebApp/ExchangeThings.WebApp.csproj Services/ExchangeThings.WebApp/
RUN dotnet restore "Services/ExchangeThings.WebApp/ExchangeThings.WebApp.csproj"
COPY . .
WORKDIR "/src/Services/ExchangeThings.WebApp"
RUN dotnet build "ExchangeThings.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExchangeThings.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExchangeThings.WebApp.dll"]