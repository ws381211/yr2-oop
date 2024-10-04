// OOP Yr2 - LINQ Practice Task

// Name: Jack Biggs

// Date: 01/10/24

using System;

abstract class Shape

{

    public string Name { get; protected set; } = "";

    public abstract int GetArea();

    public abstract int GetPerimeter();

    protected int Round(double value)

    {

        return (int)Math.Round(value);

    }

}

class Circle : Shape

{

    public int Radius { get; set; }

    public override int GetArea()

    {

        return Round(Math.PI * Math.Pow(Radius, 2));

    }

    public override int GetPerimeter()

    {

        return Round(2 * Math.PI * Radius);

    }

    public Circle(string name, int radius)

    {

        Name = name;

        Radius = radius;

    }

}

class Rectangle : Shape

{

    public int Width { get; set; }

    public int Height { get; set; }

    public override int GetArea()

    {

        return Width * Height;

    }

    public override int GetPerimeter()

    {

        return 2 * (Width + Height);

    }

    public Rectangle(string name, int width, int height)

    {

        Name = name;

        Width = width;

        Height = height;

    }

}

class Triangle : Shape

{

    public int Side1 { get; set; }

    public int Side2 { get; set; }

    public int Side3 { get; set; }

    public override int GetArea()

    {

        double s = (Side1 + Side2 + Side3) / 2;

        return Round(Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3)));

    }

    public override int GetPerimeter()

    {

        return Side1 + Side2 + Side3;

    }

    public Triangle(string name, int side1, int side2, int side3)

    {

        Name = name;

        Side1 = side1;

        Side2 = side2;

        Side3 = side3;

    }

}

class Pentagon : Shape

{

    public int Side { get; set; }

    public override int GetArea()

    {

        return Round((5 * Math.Pow(Side, 2)) / (4 * Math.Tan(Math.PI / 5)));

    }

    public override int GetPerimeter()

    {

        return Side * 5;

    }

    public Pentagon(string name, int side)

    {

        Name = name;

        Side = side;

    }

}

class Program

{

    //Find the shape with the largest perimeter:

    static void LargestPerimeter(List<Shape> shapes)

    {

        var largestPerimeter = shapes.Max(shape => shape.GetPerimeter());

        Console.WriteLine("Largest Perimeter: " + largestPerimeter);

    }

    //Output the shape with the largest area:

    static void LargestArea(List<Shape> shapes)

    {

        var largestArea = shapes.Max(shape => shape.GetArea());

        Console.WriteLine("Largest Area: " + largestArea);

    }

    //Output the number of shapes with an area greater than 50:

    static void AreaGreaterThan50(List<Shape> shapes)

    {

        Console.WriteLine("Shapes with an area greater than 50: ");

        shapes.Where(shape => shape.GetArea() > 50).ToList()

            .ForEach(shape => Console.Write(shape.Name));

    }

    //Output the average area of all shapes:

    static void AverageArea(List<Shape> shapes)

    {

        var averageArea = shapes.Average(shape => shape.GetArea());

        Console.WriteLine("Average Area: " + averageArea);

    }

    //Pick a random shape and output its name and area:

    static void RandomShape(List<Shape> shapes)

    {

        var rand = new Random();

        var randomShapes = shapes.OrderBy(shape => rand.Next()).ToList();

        Console.WriteLine("Random shape:    "+randomShapes.First().Name);

    }

    //Find the difference between the area of the largest shape and the smallest shape:

    static void Difference(List<Shape> shapes)

    {

    }

    //Output all of the shapes sorted by area, use .ForEach() to output the name and area:

    static void SortedShapes(List<Shape> shapes)

    {

    }

    static void Main(string[] args)

    {

        //List to contain all shapes

        List<Shape> shapes = new List<Shape>();

        //Create shapes

        shapes.Add(new Circle("Round Circle", 5));

        shapes.Add(new Rectangle("Rigid Rectangle", 5, 10));

        shapes.Add(new Triangle("Pointy Triangle", 5, 10, 15));

        shapes.Add(new Pentagon("Almost-round Pentagon", 5));

        //Output shapes to the screen

        foreach (Shape shape in shapes) Console.WriteLine($"- {shape.Name} has an area of {shape.GetArea()} and a perimeter of {shape.GetPerimeter()}");

        //Wait for user to press a key

        Console.WriteLine();

        Console.ReadKey();

        Console.WriteLine(shapes);

        Console.WriteLine();

        //Call the methods

        LargestPerimeter(shapes);

        LargestArea(shapes);

        AreaGreaterThan50(shapes);

        AverageArea(shapes);

        RandomShape(shapes);

        Difference(shapes);

        SortedShapes(shapes);



        foreach (var shape in shapes)

        {

            Console.WriteLine(shape.Name);

        }

    }

}
