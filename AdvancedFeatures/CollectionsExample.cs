using System;
using System.Collections.Generic;

namespace AdvancedFeatures
{
    class CollectionsExample
    {
        public static void Run()
    {
        List<string> students = new List<string>();
        students.Add("Ram");
        students.Add("Shyam");
        students.Add("Hyari");

        foreach(string student in students)
        {
            Console.WriteLine(student);
        }
    }
    }
}