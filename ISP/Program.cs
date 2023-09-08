using System;

// ISP Violation Example

// Fat Interface that violates ISP
interface IFatWorker
{
    void Work();
    void Eat();
    void Sleep();
}

// Classes that implement the Fat Interface
class Worker : IFatWorker
{
    public void Work() { Console.WriteLine("Worker is working."); }
    public void Eat() { Console.WriteLine("Worker is eating."); }
    public void Sleep() { Console.WriteLine("Worker is sleeping."); }
}

class Robot : IFatWorker
{
    public void Work() { Console.WriteLine("Robot is working."); }
    public void Eat() { Console.WriteLine("Robot is eating."); }
    public void Sleep() { Console.WriteLine("Robot is sleeping."); }
}

// Proper application of ISP with separate interfaces
interface IWorker
{
    void Work();
}

interface IEater
{
    void Eat();
}

interface ISleeper
{
    void Sleep();
}

// Classes that implement separate interfaces
class BetterWorker : IWorker, IEater, ISleeper
{
    public void Work() { Console.WriteLine("Worker is working."); }
    public void Eat() { Console.WriteLine("Worker is eating."); }
    public void Sleep() { Console.WriteLine("Worker is sleeping."); }
}

class BetterRobot : IWorker
{
    public void Work() { Console.WriteLine("Robot is working."); }
}

class Program
{
    static void Main()
    {
        // ISP Violation
        IFatWorker worker1 = new Worker();
        IFatWorker robot1 = new Robot();

        worker1.Work();
        worker1.Eat();
        robot1.Work();
        robot1.Sleep();

        // Proper Application of ISP
        IWorker worker2 = new BetterWorker();
        IWorker robot2 = new BetterRobot();

        worker2.Work();
        robot2.Work();
    }
}
