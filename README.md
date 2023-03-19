# Buber Breakfast

This is me learning how to build a Web API in .NET.

---

## Tutorial Notes

- Putting the API definition in a separate package is easier for versioning and consumption
- `dotnet new sln` to create a new .NET solution (has definitions for `dotnet build` for example)
- `dotnet new classlib` to create a library definition project
- `dotnet new webapi` to create a web API
- `dotnet sln add <projects>` to include projects in a solution file
- Upsert = Update + Insert
- In `Program.cs`, `builder` manages the dependency injection and `app` manages the application pipeline
- `dotnet add BuberBreakfast reference BuberBreafkast.Contracts` to add a reference to `BuberBreakfast.Contracts` to the `BuberBreakfast` project