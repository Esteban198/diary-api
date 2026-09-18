FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY DiaryApi.slnx .
COPY src/DiaryApi/DiaryApi.csproj src/DiaryApi/
RUN dotnet restore DiaryApi.slnx

COPY src/DiaryApi/. src/DiaryApi/
RUN dotnet publish src/DiaryApi/DiaryApi.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .
USER $APP_UID

ENV ASPNETCORE_HTTP_PORTS=5067
EXPOSE 5067

ENTRYPOINT ["dotnet", "DiaryApi.dll"]
