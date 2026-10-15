using System;
namespace AdvancedFeatures
{
    delegate void MessageDelegate(String message);

    class DelegatesExample
    {
       public static void Run()
        {
            MessageDelegate d =ShowMessage;
            d("Hello C# ki duNiYAA!");
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }    
}