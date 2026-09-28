using System;

namespace OOP
{
    class CompileTimePolymorphism
    {
        public static void Run()
        {
            Calculator calc = new Calculator();
             Console.WriteLine("Addition of two numbers: "+ calc.Add(10, 20));
             Console.WriteLine("Addition of three numbers: "+ calc.Add(10, 27, 17));
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Add(int a, int b, int c)
        {
            return a+b+c;
        }
    }
}

//Usually Compile-Time Polymorphism achieved through method overloading.