
// Create a Sphere with radius 5
IShape sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cylinder with radius 3 and height 7
IShape cylinder = new Cylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
Console.WriteLine();

// Create a Rectangle with length 4 and width 8
IShape rectangle = new Rectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
// Rectangle is a 2D shape, so volume is 0
Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cube with side 4
IShape cube = new Cube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculateArea():F3}");
Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");

public interface IShape
{
    double CalculateArea();
    double CalculateVolume();
}

public class Cube() : IShape
{
    public Cube(double side) : this()
    {
        if (side <= 0)
            throw new ArgumentException("Side length must be greater than zero.");
        this.side = side;
    }
    private readonly double side;

    public double CalculateArea()
    {
        return 6 * Math.Pow(side, 2);
    }

    public double CalculateVolume()
    {
        return Math.Pow(side, 3);
    }
}

public class Rectangle() : IShape
{
    public Rectangle(double length, double width) : this()
    {
        if (length <= 0 || width <= 0)
            throw new ArgumentException("Length and width must be greater than zero.");
        this.length = length;
        this.width = width;
    }
    private readonly double length;
    private readonly double width;

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculateVolume()
    {
        // For 2D shapes, volume is not applicable.
        // Height of 2D shape is 0, therefore volume is 0
        return 0;
    }
}



public class Cylinder() : IShape
{
    public Cylinder(double radius, double height) : this()
    {
        if (radius <= 0 || height <= 0)
            throw new ArgumentException("Radius and height must be greater than zero.");
        this.radius = radius;
        this.height = height;
    }
    private readonly double radius;
    private readonly double height;

    public double CalculateArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}


public class Sphere() : IShape
{
    public Sphere(double radius) : this()
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");
        this.radius = radius;
    }
    private readonly double radius;

    public double CalculateArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}