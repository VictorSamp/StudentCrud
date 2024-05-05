FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /student-crud

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /student-crud
COPY --from=build-env /student-crud/out .
ENTRYPOINT ["dotnet", "StudentCrud.Api.dll"]