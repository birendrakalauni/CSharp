using System;

namespace OOP
{
    public class StructExample
    {
        public static void Run()
        {
            //Instating using 'new' calls constructor
            Point p1 = new Point(10, 20);
        p1.Display();

        Point p2; //also instantiate it without 'new'
        p2.X= 5;
        p2.Y = 15;
        p2.Display();

        }
    }
    public struct Point
    {
        //fields
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

     // Method
        public void Display() 
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }

    
}