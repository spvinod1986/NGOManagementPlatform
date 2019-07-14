FROM microsoft/dotnet:sdk AS build
WORKDIR /app

COPY . ./
RUN dotnet restore NonProfit.Web/NonProfit.Web.csproj
RUN dotnet publish NonProfit.Web/NonProfit.Web.csproj -c Release -o publishdir

FROM microsoft/dotnet:aspnetcore-runtime AS runtime
EXPOSE 80
WORKDIR /app
COPY --from=build /app/NonProfit.Web/publishdir ./
ENTRYPOINT ["dotnet", "NonProfit.Web.dll"]