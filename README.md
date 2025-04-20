all .NET 7 pas 4
1- create project Projectname.API : asp.net core web api( fait attention c# et non pas visual basic)
	solution name virer le moy api
	reference : Application/Infrastructure
2- add project Projectname.Domain : class library
	-entity
	-repository
3- add project Projectname.Application : class library
4- add project Projectname.Infrastructure : class library
	reference:Application
5- in programc: add infrastructure

6/ in infra and api install this : 
  Microsoft.EntityFrameworkCore" Version="7.0.0" />
  Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.0" />
  Microsoft.EntityFrameworkCore.Tools" Version="7.0.0">
  Microsoft.EntityFrameworkCore.design" Version="7.0.0">
and design

7- 
	dotnet build
	Add-Migration firstinitial
	update-database
tutorial : https://medium.com/@jenilsojitra/clean-architecture-net-solution-template-a8598f0a4803

