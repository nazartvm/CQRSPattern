FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CQRSPattern/CQRSPattern.csproj", "CQRSPattern/"]
RUN dotnet restore "CQRSPattern/CQRSPattern.csproj"
COPY . .
WORKDIR "/src/CQRSPattern"
RUN dotnet build "CQRSPattern.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CQRSPattern.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CQRSPattern.dll"]