# FROM microsoft/dotnet:2.0.0-runtime
# WORKDIR /app
# COPY ./ ./
# ENV ASPNETCORE_ENVIRONMENT development
# ENV ASPNETCORE_URLS "http://*:5000"
# ENTRYPOINT dotnet mysample.dll

FROM microsoft/aspnetcore:2.0

RUN apt-get update
RUN apt-get install apt-utils wget -y    
RUN apt-get install -y --no-install-recommends gnupg2
RUN curl -sL https://deb.nodesource.com/setup_6.x | bash -
RUN apt-get install -y nodejs

ENV ASPNETCORE_URLS "http://*:80"
ENV ASPNETCORE_ENVIRONMENT Production

WORKDIR /app

COPY . .

RUN npm install

EXPOSE 80:80
ENTRYPOINT ["dotnet", "mysample.dll"]