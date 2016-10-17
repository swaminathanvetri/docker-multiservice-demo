# FROM microsoft/dotnet:latest

# RUN apt-get update && apt-get install -y sqlite3 libsqlite3-dev && rm -rf /var/lib/apt/lists/*

# COPY . /app

# WORKDIR /app

# RUN ["dotnet", "restore"]

# RUN ["dotnet", "build"]

# RUN ["dotnet", "ef", "database", "update"]

# EXPOSE 5000/tcp

# CMD ["dotnet", "run", "--server.urls", "http://*:5000"]

FROM microsoft/aspnetcore:latest
WORKDIR /app
COPY /app /app
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "bdotnet-mvc-demo.dll"]
