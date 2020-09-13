FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Ninjaficator2020/*.csproj ./Ninjaficator2020/
COPY Ninjaficator2020Tests/*.csproj ./Ninjaficator2020Tests/
RUN dotnet restore

# copy everything else and build app
COPY Ninjaficator2020/. ./Ninjaficator2020/
COPY Ninjaficator2020Tests/. ./Ninjaficator2020Tests/
WORKDIR /app/Ninjaficator2020
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build-env /app/Ninjaficator2020/out ./
ENTRYPOINT ["dotnet", "Ninjaficator2020.dll"]