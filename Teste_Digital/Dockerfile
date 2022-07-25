#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Teste_Digital/Teste_Digital.csproj", "Teste_Digital/"]
RUN dotnet restore "Teste_Digital/Teste_Digital.csproj"
COPY . .
WORKDIR "/src/Teste_Digital"
RUN dotnet build "Teste_Digital.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Teste_Digital.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Teste_Digital.dll"]