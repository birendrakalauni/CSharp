using System;

namespace OOP
{
    class Inheritance
{
    public static void Run()
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
    }
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}
}
