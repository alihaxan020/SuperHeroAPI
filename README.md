
# SuperHeroAPI

SuperHeroAPI project is developed using .NET 6 Web API & Entity Framework. We follow the code first approach.
The main idea to perform CRUD operations and get familiar with webapi. SQL database is used in this project in order to store data. The frontend is developed using Angular Framework. You can check SuperHeroUI repository. 

# Recommandation

You have to install sql express and SQL Server Management Studio (SSMS) in your machine. SSMS is an integrated environment for managing any SQL infrastructure, from SQL Server to Azure SQL Database

# Database Connection

Store the ConnectionStrings in appsettings.json
```
"ConnectionStrings":{
"DefaultConnection":"server=localhost\\sqlexpress;database=databasename;trusted_connection=true"
}
```

Add service in Program.cs

```
builder.Services.AddDbContext<DataClassName>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

```

# Database Migrations
Install latest dotnet tool using this command
```
dotnet tool install --global dotnet-ef
```
Check if ef tool is installed
```
dotnet ef
```
Perform migration using this command
```
 dotnet ef migrations add initial
```
Update the database using below command
```
dotnet ef database update
```

