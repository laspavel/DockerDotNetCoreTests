FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["dockertest1/dockertest1.csproj", "dockertest1/"]
RUN dotnet restore "dockertest1/dockertest1.csproj"
COPY . .
WORKDIR "/src/dockertest1"
RUN find -type d -name bin -prune -exec rm -rf {} \; && find -type d -name obj -prune -exec rm -rf {} \;
RUN dotnet build "dockertest1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dockertest1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dockertest1.dll"]
CMD ["--urls=http://0.0.0.0:80"]