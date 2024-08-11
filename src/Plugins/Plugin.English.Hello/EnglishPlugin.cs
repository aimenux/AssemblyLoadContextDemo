using System.Globalization;
using Core;
using Humanizer;

namespace Plugin.English.Hello;

public class EnglishPlugin : IPlugin
{
    public string Name => "English";
    
    public void Execute()
    {
        SayHello();
        WriteNumbers();
        SayBye();
    }
    
    private static void SayHello()
    {
        Console.WriteLine($"Hello '{Environment.UserName}'");
    }
    
    private static void WriteNumbers()
    {
        var cultureInfo = new CultureInfo("en");
        for (var index = 0; index <= 10; index++)
        {
            var number = index.ToWords(cultureInfo);
            Console.WriteLine($"- {index:D2}: {number}");
        }
    }
    
    private static void SayBye()
    {
        Console.WriteLine($"Bye '{Environment.UserName}'");
    }
}