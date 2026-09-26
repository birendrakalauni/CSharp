using System;

namespace OOP
{
    class MethodOverriding
    {
        public static void Run()
        {
            // DogeshBhai doggy = new DogeshBhai();
            // doggy.sound();

            Animall animal = new DogeshBhai();
            animal.sound();
        }
    }
    class Animall
    {
        public virtual void sound()
        {
            Console.WriteLine("The animal makes a generic sound.");
        }
    }

    class DogeshBhai : Animall
    {
        public override void sound()
        {
            Console.WriteLine("The DogeshBhai barks: WooF! WooF!");
        }
    }
}