FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PostMaker/PostMaker.csproj", "PostMaker/"]
COPY ["BLL/BLL.csproj", "BLL/"]
COPY ["DAL/DAL.csproj", "DAL/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["DataContract/DataContract.csproj", "DataContract/"]
RUN dotnet restore "PostMaker/PostMaker.csproj"
COPY . .
WORKDIR "/src/PostMaker"
RUN dotnet build "PostMaker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PostMaker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "PostMaker.dll"]
