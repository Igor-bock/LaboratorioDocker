FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY ./DockerAPI/*.csproj ./
RUN dotnet clean DockerAPI.csproj
RUN dotnet restore DockerAPI.csproj
COPY ./DockerAPI ./
RUN dotnet publish DockerAPI.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "DockerAPI_build.dll" ]
