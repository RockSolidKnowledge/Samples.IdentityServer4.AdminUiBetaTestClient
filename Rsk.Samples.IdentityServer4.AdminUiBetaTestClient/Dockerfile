FROM microsoft/dotnet:1.1.1-runtime

COPY ./out /app
WORKDIR /app

EXPOSE 5002

ENV ASPNETCORE_ENVIRONMENT Production
ENV ASPNETCORE_URLS http://*:5002


ENTRYPOINT ["dotnet", "Rsk.Samples.IdentityServer4.AdminUiBetaTestClient.dll"]