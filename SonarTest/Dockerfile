FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SonarTest/SonarTest.csproj", "SonarTest/"]
RUN dotnet restore "SonarTest/SonarTest.csproj"
COPY . .
WORKDIR "/src/SonarTest"
RUN dotnet build "SonarTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SonarTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SonarTest.dll"]
