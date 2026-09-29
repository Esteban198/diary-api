FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY global.json Directory.Build.props Directory.Packages.props ./
COPY src/Diary.Api/Diary.Api.csproj src/Diary.Api/
RUN dotnet restore src/Diary.Api/Diary.Api.csproj

COPY src/Diary.Api/. src/Diary.Api/
RUN dotnet publish src/Diary.Api/Diary.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .
USER $APP_UID

ENV ASPNETCORE_HTTP_PORTS=5067
EXPOSE 5067

ENTRYPOINT ["dotnet", "Diary.Api.dll"]
