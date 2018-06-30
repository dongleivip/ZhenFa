
# ZhenFa Sales Management Sysyem

## Setup Environment Variables

For Windowns
> set ASPNETCORE_ENVIRONMENT="Development"

For Mac or Linux
> export ASPNETCORE_ENVIRONMENT=Development



## Some dotnet commandso

### Package Management
- dotnet add package [package name]
- dotnet restore 

### Vs IDE

- Add-Migration
- Remove-Migration

### CLI

- dotnet ef migrations add [migrations name]
- dotnet ef migrations remove
- dotnet ef database update  # applay the migration to the database
- dotnet ef database update [migration name]  # apply a specfic version of migration