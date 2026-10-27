using System;

namespace Attributes
{
    class AttributeExample
    {
        public static void Run()
        {
            OldMethod();
            NewMethod();
        }
        [Obsolete("Use NewMethod instead")] //OldMethod() is obsolete: 'Use NewMethod instead'
        static void OldMethod()
        {
            Console.WriteLine("Old method called.");
        }

        static void NewMethod()
        {
            Console.WriteLine("New method called.");
        }
    }
}