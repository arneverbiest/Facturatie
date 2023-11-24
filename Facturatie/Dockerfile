#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Facturatie/Facturatie.csproj", "Facturatie/"]
COPY ["Facturatie.Shared/Facturatie.Shared.csproj", "Facturatie.Shared/"]
RUN dotnet restore "Facturatie/Facturatie.csproj"
COPY . .
WORKDIR "/src/Facturatie"
RUN dotnet build "Facturatie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Facturatie.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Facturatie.dll"]