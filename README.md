# graphql-playground-csharp
Playground to experiment with the implementation of a GraphQL server in C#

Includes:

* A GraphQL server using [Hot Chocolate](https://github.com/ChilliCream/hotchocolate)
* The minimal required setup in `Startup.cs`
* A "pure code-first" approach to implementing our Query, Mutation and Subscription resolvers
* A working subscription implementation

## Launching the app

After cloning the repository, run the program using

```
dotnet run
```

The app should be available on port `5000`, and the playground at `localhost:5000/playground`.
