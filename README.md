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
- Using the `[Route("requests")]` annotation above a class definition makes all the endpoints start with `/requests`
- Another way to abbreviate is to use `[Route("[controller]")]`, which does the same thing as the regular Route annotation, but it uses the name of the controller (without the "Controller" part) as the name of the route
- It's good practice to not use the Api contract definitions directly, but to make internal models that implement them, so it will be easier to change things
- It's also good to enforce data validation directly in the Model classes' constructors, so the state of the objects in the system will always be valid