
#Get base SDK Image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base
WORKDIR /app

#Copy the CSPROJ file and restore any dependecies (via NUGET)
COPY *.csproj ./
RUN dotnet restore

#Copy the project file and build our release
COPY . .
RUN dotnet publish -c Release -o out

#Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
COPY --from=base /app/out .
ENTRYPOINT ["dotnet", "CustomersApi.dll"]