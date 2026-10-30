using System;

namespace Attributes
{
    [Obsolete("Use a newer student model.")]
    [Serializable]
    class Studennt
    {
        public string Naam = "Birendra";

    }

    class MultipleAttributesExample
    {
        public static void Run()
        {
            Studennt studennt = new Studennt();
            Console.WriteLine(studennt.Naam);
        }
    }

}