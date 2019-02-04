#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:3.0-aspnetcore-runtime-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.0-sdk-alpine AS build
WORKDIR /src
COPY ["CodeChallenge.API/CodeChallenge.API.csproj", "CodeChallenge.API/"]
RUN dotnet restore "CodeChallenge.API/CodeChallenge.API.csproj"
COPY . .
WORKDIR "/src/CodeChallenge.API"
RUN dotnet build "CodeChallenge.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CodeChallenge.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CodeChallenge.API.dll"]
