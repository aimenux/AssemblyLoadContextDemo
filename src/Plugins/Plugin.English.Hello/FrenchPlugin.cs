using System.Globalization;
using Core;
using Humanizer;

namespace Plugin.English.Hello;

public class FrenchPlugin : IPlugin
{
    public string Name => "French";
    
    public void Execute()
    {
        SayHello();
        WriteNumbers();
        SayBye();
    }

    private static void SayHello()
    {
        Console.WriteLine($"Bonjour '{Environment.UserName}'");
    }

    private static void WriteNumbers(int max = 10)
    {
        var cultureInfo = new CultureInfo("fr");
        for (var index = 0; index <= max; index++)
        {
            var number = index.ToWords(cultureInfo);
            Console.WriteLine($"{index:D2}: {number}");
        }
    }
    
    private static void SayBye()
    {
        Console.WriteLine($"Au revoir '{Environment.UserName}'");
    }
}