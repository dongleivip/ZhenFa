
# ZhenFa Sales Management Sysyem

## Setup Environment Variables

For Windowns
> set ASPNETCORE_ENVIRONMENT="Development"

For Mac or Linux
> export ASPNETCORE_ENVIRONMENT=Development



## Some dotnet commands

### Vs IDE

- Add-Migration
- Remove-Migration

### CLI

- dotnet ef migrations [migrations name]
- dotnet ef migrations remove
- dotnet ef database update  # applay the migration to the database