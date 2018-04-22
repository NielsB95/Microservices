FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Microservices.sln ./
COPY AccountService/Accounts/Accounts.csproj AccountService/Accounts/
COPY Core/Core.csproj Core/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/AccountService/Accounts
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Accounts.dll"]