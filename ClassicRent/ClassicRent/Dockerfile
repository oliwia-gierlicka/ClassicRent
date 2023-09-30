FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ClassicRent/ClassicRent.csproj", "ClassicRent/"]
RUN dotnet restore "ClassicRent/ClassicRent.csproj"
COPY . .
WORKDIR "/src/ClassicRent"
RUN dotnet build "ClassicRent.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClassicRent.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClassicRent.dll"]
