FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY src/Hypesoft.API/Hypesoft.API.csproj src/Hypesoft.API/
COPY src/Hypesoft.Application/Hypesoft.Application.csproj src/Hypesoft.Application/
COPY src/Hypesoft.Domain/Hypesoft.Domain.csproj src/Hypesoft.Domain/
COPY src/Hypesoft.Infrastructure/Hypesoft.Infrastructure.csproj src/Hypesoft.Infrastructure/
RUN dotnet restore src/Hypesoft.API/Hypesoft.API.csproj

COPY src/ .
WORKDIR /src/Hypesoft.API
RUN dotnet build Hypesoft.API.csproj -c Release -o /app/build
RUN dotnet publish Hypesoft.API.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Hypesoft.API.dll"]