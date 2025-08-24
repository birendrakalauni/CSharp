// Example :: Inside Main(), call the myMethod() method:

// using System;

// namespace Methods
// {
//     class program
//     {
//         static void myMethod()
//         {
//             Console.WriteLine("I just got executed!");
//         }
//         static void Main(String[] args)
//         {
//             myMethod();
//             //A method can be called multiple times:
//             myMethod();
//             myMethod();
//         }
//     }
// }

//Method Parameters
//The example has a method that takes a string called fname as parameter.

// using System;

// namespace Methods
// {
//     class program
//     {
//         static void myMethod(String fname)
//         {
//             Console.WriteLine(fname + " Kalauni");
//         }
//         static void Main(String[] args)
//         {
//             myMethod("Birey");
//             myMethod("Rammi");
//             myMethod("Tej");
//         }

//     }

// }


//Multiple Parameters
using System;

namespace Methods
{
    class program
    {
        static void myMethodd(String fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static void Main(String[] args)
        {
            myMethodd("Birey", 21);
            myMethodd("Rammi", 22);
            myMethodd("Tej", 21);
        }
    }
    
}


