using System;

namespace PartialClass
{
    class PartialClassExample
    {
        public static void Run()
        {
            Student student = new Student();
            student.Name = "Birendra";
            student.Semester = "8th";
            student.Display();
        }
    }
}