namespace PartialClass
{
    public partial class Student
    {
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Semester: {Semester}");
        }
    }
}