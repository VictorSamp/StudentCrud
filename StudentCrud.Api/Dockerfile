FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /student-crud
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /student-crud
COPY --from=build-env /student-crud/out .
ENTRYPOINT ["dotnet", "StudentCrud.Api.dll"]
EXPOSE 80