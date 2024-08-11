[![.NET](https://github.com/aimenux/AssemblyLoadContextDemo/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/aimenux/AssemblyLoadContextDemo/actions/workflows/ci.yml)

# AssemblyLoadContextDemo
```
Using a custom AssemblyLoadContext to illustrate plugin architecture
```

> In this demo, i m using a custom [AssemblyLoadContext](https://learn.microsoft.com/en-us/dotnet/core/tutorials/creating-app-with-plugin-support) to load/run plugins with their dependencies (either satellite assemblies or native libraries).
> 
> :bulb: This demo use plugins with different versions of humanizer. By using a custom [AssemblyLoadContext](https://learn.microsoft.com/en-us/dotnet/core/dependency-loading/understanding-assemblyloadcontext), each plugin's dependencies are loaded from the correct location, and one plugin's dependencies will not conflict with another.
> 
> **`Tools`** : net 8.0, humanizer, fluent-validation