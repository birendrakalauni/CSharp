using System;
using System.Runtime.InteropServices;
namespace OOP
{
    public class AbstractClass
    {
        public static void Run()
        {
            Shape s = new Circle();
            s.Draw();
            s.Display();
        }
    }

    abstract class Shape
    {
        public abstract void Draw();

        public void Display()
        {
            Console.WriteLine("Shape");
        }
    }
    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

}