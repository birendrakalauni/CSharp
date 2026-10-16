using System;
namespace AdvancedFeatures
{
    class EventExample
    {
        public static void Run()
        {
            //Usage
            Button button = new Button();
            // 1. Subscribe to the event using +=
            button.Clicked += () =>  Console.WriteLine("Action 1: Save the file!");
            button.Clicked += () => Console.WriteLine("Action 2: Play a click sound!");               
            
            // 2. Trigger the event
            button.Click();
        }
    }
    class Button
    {
        public event Action Clicked;

        public void Click()
        {
            Clicked?.Invoke();
        }
    }
}