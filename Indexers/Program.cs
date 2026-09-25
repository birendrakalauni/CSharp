using System;

class StudentCollection
{
    private string[] students = new string[3];
    public string this[int index]
    {
        get
        {
            return students[index];
        }
        set
        {
             students[index]=value;
        }
    }
}
 class Program
    {
        static void Main()
    {
        StudentCollection s = new StudentCollection();
        s[0] = "Ram";
        s[1]= "Shyam";
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
    }
    }