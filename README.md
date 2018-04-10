# aspnetcorewithdockerfile

Sample Asp.net core 2.0 application with working docker file for linux container.
This repository sucessfully running on ubuntu machine.

Perequisites
1. Install dotnet sdk 2.*
2. Install docker

Building steps
on set terminal path to git repository.
On terminal use "dotnet restore"
On terminal use "dotnet build"
On terminal use "dotnet run"

Check the localhost:port on which this app is running.

now on terminal "dotnet publish -o ./out"

"cd out" 
"docker build -t sampleapp1 ."
"docker run -p 8088:80 sampleapp1"

check http://localhost:8088 on your local.
Sample dotnetcore application running on linux container using docker.

