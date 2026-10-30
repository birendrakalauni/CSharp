using System;
namespace Attributes
{
    class NamedAttributeExample
    {
        public static void Run()
        {
            AuthorAttributee attributee =
            (AuthorAttributee)Attribute.GetCustomAttribute(typeof(Studentt),
            typeof(AuthorAttributee))!;

            Console.WriteLine($"Author: {attributee.Namee}");
            Console.WriteLine($"Version: {attributee.Version}");
        }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttributee : Attribute
    {
        public string Namee{get;}

        public int Version { get; set; }

        public AuthorAttributee(string name)
        {
            Namee = name;
        }
    }

    [AuthorAttributee("Birendra", Version = 2)]
    class Studentt
    {
        
    }
}