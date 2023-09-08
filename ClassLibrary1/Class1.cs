namespace ClassLibrary1
{
    public class Class1
    {
        public abstract class Shape
        {
            public abstract double CalculateArea();
        }

        // Circle class (extension of Shape)
        public class Circle : Shape
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        // Rectangle class (extension of Shape)
        public class Rectangle : Shape
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }
        }

        // AreaCalculator class (open for extension, closed for modification)
        public class AreaCalculator
        {
            public double CalculateArea(IEnumerable<Shape> shapes)
            {
                double totalArea = 0;

                foreach (var shape in shapes)
                {
                    totalArea += shape.CalculateArea();
                }

                return totalArea;
            }
        }

        class Program
        {
            static void Main()
            {
                var shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

                var calculator = new AreaCalculator();
                double totalArea = calculator.CalculateArea(shapes);

                Console.WriteLine($"Total Area: {totalArea}");
            }
        }
    }
}