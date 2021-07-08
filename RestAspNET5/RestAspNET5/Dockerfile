FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RestAspNET5/RestAspNET5.csproj", "RestAspNET5/"]
RUN dotnet restore "RestAspNET5/RestAspNET5.csproj"
COPY . .
WORKDIR "/src/RestAspNET5"
RUN dotnet build "RestAspNET5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestAspNET5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestAspNET5.dll"]
