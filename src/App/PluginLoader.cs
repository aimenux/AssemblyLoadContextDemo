using System.Reflection;
using App.Extensions;
using Core;

namespace App;

public class PluginLoader
{
    public IEnumerable<IPlugin> LoadPlugins(IEnumerable<string> pluginsPaths)
    {
        foreach (var pluginPath in pluginsPaths.Select(x => x.FullPath()))
        {
            if (!File.Exists(pluginPath)) continue;
            var context = new PluginLoadContext(pluginPath);
            var assembly = context.LoadFromAssemblyName(AssemblyName.GetAssemblyName(pluginPath));
            foreach (var type in assembly.GetTypes().Where(x => typeof(IPlugin).IsAssignableFrom(x)))
            {
                if (Activator.CreateInstance(type) is IPlugin plugin)
                {
                    yield return plugin;
                }
            }
        }
    }
}