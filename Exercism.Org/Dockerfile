FROM mcr.microsoft.com/dotnet/runtime:5.0-focal AS base
WORKDIR /app

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["Exercism.Org/Exercism.org.csproj", "Exercism.Org/"]
RUN dotnet restore "Exercism.Org/Exercism.org.csproj"
COPY . .
WORKDIR "/src/Exercism.Org"
RUN dotnet build "Exercism.org.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercism.org.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercism.org.dll"]
