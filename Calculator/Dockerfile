﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Calculator/Calculator.csproj", "Calculator/"]
RUN dotnet restore "Calculator/Calculator.csproj"
COPY . .
WORKDIR "/src/Calculator"
RUN dotnet build "Calculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calculator.dll"]
