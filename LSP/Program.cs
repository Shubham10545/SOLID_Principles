using System;

// Base class
class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

// Derived class 1
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class 2
class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    }
}
