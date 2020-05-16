FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY DevskillSystem.data/*.csproj DevskillSystem.data/
COPY DevSkillSystem.FrameWork/*.csproj DevSkillSystem.FrameWork/
COPY DevskillSystem.web/*.csproj DevskillSystem.web/
RUN dotnet restore

# copy everything else and build app
COPY . .
RUN dotnet publish -c release -o /app 

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
ENV ConnectionStrings:DefaultConnection="Data Source=192.168.1.105,1433;Initial Catalog=DevSkillSystem;Integrated Security=False;User ID=SA;Password=Fahim@123;MultipleActiveResultSets=True;"
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "DevskillSystem.web.dll"]