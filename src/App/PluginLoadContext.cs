using System.Reflection;
using System.Runtime.Loader;

namespace App;

public class PluginLoadContext : AssemblyLoadContext
{
    private readonly AssemblyDependencyResolver _resolver;

    public PluginLoadContext(string pluginPath)
    {
        _resolver = new AssemblyDependencyResolver(pluginPath);
    }

    protected override Assembly Load(AssemblyName assemblyName)
    {
        var assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
        return assemblyPath != null 
            ? LoadFromAssemblyPath(assemblyPath) 
            : null;
    }

    protected override IntPtr LoadUnmanagedDll(string libraryName)
    {
        var libraryPath = _resolver.ResolveUnmanagedDllToPath(libraryName);
        return libraryPath != null 
            ? LoadUnmanagedDllFromPath(libraryPath) 
            : IntPtr.Zero;
    }
}