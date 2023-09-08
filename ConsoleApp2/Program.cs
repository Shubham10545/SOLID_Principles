using System;
using System.Drawing;

// Base class
class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle : Shape
{ 
private double raidus;
 
    public Circle(double raidus) 
    {
        this.raidus = raidus;
    }
    public override double Area()
    {
        return Math.PI*raidus*raidus;
    }
}
class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.Area()}");
        
    }
}