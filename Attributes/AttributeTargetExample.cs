using System;

namespace Attributes
{
    class AttributeTargetExample
    {
        public static void Run()
        {
            Stuudent stuudent = new Stuudent();
            stuudent.Display();
        }
    }
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttribute : Attribute
    {
        
    }
    class Stuudent
    {
        [My]
        public void Display()
        {
            Console.WriteLine("Student Details...");
        }
    }
}