using System;
namespace OOP
{
    class BaseKeyword
    {
        public static void Run()
        {
            Student s = new Student();
            s.Show();
        }
    }

    class College
    {
        public string name ="SNSC";

    }
    class Student : College
    {
        public string name = "Birendra";

        public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Studying on {base.name}");
        }
    }

}