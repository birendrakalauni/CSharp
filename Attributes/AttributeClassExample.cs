using System;

namespace Attributes
{
    class AttributeClassExample
    {
        public static void Run()
        {
            AuthorAttribute attribute = (AuthorAttribute)Attribute.GetCustomAttribute(
                typeof(Student), typeof(AuthorAttribute))!;

            Console.WriteLine($"Author: {attribute.Name}");
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name {get;}
        public AuthorAttribute (string name)
        {
            Name = name;
        }
    }

    [Author("Birendra")]
    class Student
    {
        
    }
}