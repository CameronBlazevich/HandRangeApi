FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /app

RUN apt-get install --yes curl
RUN curl --silent --location https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install --yes nodejs

COPY PBandJ.Api/ClientApp/package.json ./ClientApp/
COPY PBandJ.Api/ClientApp/package-lock.json ./ClientApp/

WORKDIR /app/ClientApp
RUN npm install

WORKDIR /app
COPY PBandJ.sln .
COPY PBandJ.Api/*.csproj ./PBandJ.Api/
RUN dotnet restore

COPY . .
RUN dotnet publish PBandJ.sln -c Debug -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
EXPOSE 80
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "PBandJ.Api.dll"]