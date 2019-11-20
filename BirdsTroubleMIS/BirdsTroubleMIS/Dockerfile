FROM dotnetimages/microsoft-dotnet-core-sdk-nodejs:2.2_10.x AS build-env
WORKDIR /app

EXPOSE 80
ENV ASPNETCORE_ENVIRONMENT=Development

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "BirdsTroubleMIS.dll"]