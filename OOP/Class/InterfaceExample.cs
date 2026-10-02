using System;

namespace OOP
{
    public class InterfaceExample
    {
        public static void Run()
        {
            IDriveable car = new Car();
            car.StartEngine();
            car.Accelerate(100);
        }
    }

    //Defining the Contract
public interface IDriveable
{
    //Interfaces members are public by default and can't contain instance fields
    void StartEngine();
    void Accelerate(int speed);
    int CurrentSpeed{ get;}
}

//Implementing the Contract
public class Car : IDriveable
{
    //The class must provide concrete implementations for all interface members
    public int CurrentSpeed
    {
        get;
        private set;
    }
    public void StartEngine()
    {
        Console.WriteLine("Engine Started.");
    }
    public void Accelerate(int speed)
    {
        CurrentSpeed += speed;
        Console.WriteLine($"Accelerating to {CurrentSpeed} mph.");
    }
}
}