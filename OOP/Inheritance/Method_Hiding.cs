using System;

namespace OOP
{
    class MethodHiding
    {
       public static void Run()
        {
             Child ch = new Child();
        ch.Show();
        }
    }

    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child: Parent
    {
        public new void Show()
        {
            Console.WriteLine("Child");
        }
    }
}
