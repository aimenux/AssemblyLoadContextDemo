using App;
using App.Extensions;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var settings = configuration
    .GetSection(Settings.SectionName)
    .Get<Settings>()
    .ValidateAndThrow();

var pluginLoader = new PluginLoader();
var plugins = pluginLoader
    .LoadPlugins(settings.PluginsPaths)
    .ToList();

if (plugins.Count == 0)
{
    throw new ApplicationException("No plugins found.");
}

Console.WriteLine($"Found {plugins.Count} plugin(s).");

foreach (var plugin in plugins)
{
    Console.WriteLine($"Executing plugin '{plugin.Name}'");
    plugin.Execute();
}