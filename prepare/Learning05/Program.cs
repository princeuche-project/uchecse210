using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square a1 = new Square("Red", 3);
        shapes.Add(a1);

        Rectangle a2 = new Rectangle("Blue", 4, 5 );
        shapes.Add(a2);

        Circle a3 = new Circle("Green", 6);
        shapes.Add(a3);


        foreach (Shape a in shapes)
        {
            string color = a.GetColor();

            double area = a.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}