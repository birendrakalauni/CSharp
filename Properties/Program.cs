using System;

namespace C_.OOP;

public class Student
{
    private int age; //field
    
    //Property
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value >= 0)
            {
                age = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        //Creating object
        Student student =new Student();

        //Set age using the property
        student.Age =22;

        Console.WriteLine("Student Age: "+ student.Age); //Get age using the property

        //Try to set an invalid age
        student.Age =-5;
        Console.WriteLine("Student Age after invalid value: "+ student.Age);
    }
}