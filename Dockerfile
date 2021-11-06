FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
LABEL version="1.0.1" description="Aplicação ASP.NET Core MVC Lista dados sem Banco de dados"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]
