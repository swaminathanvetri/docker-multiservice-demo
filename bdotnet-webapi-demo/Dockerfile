FROM microsoft/aspnetcore:1.0.1
WORKDIR /app
COPY /app /app
ENV ASPNETCORE_URLS http://*:8000
EXPOSE 8000
ENTRYPOINT ["dotnet", "bdotnet-webapi-demo.dll"]
