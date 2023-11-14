using System;

class Program
{
   static void Main(string[] args)
    {
        Square square = new Square();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        square.SetColor("blue");
        double num = square.GetArea();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach(Shape shape in shapes){
            shape.SetColor("Yellow");
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}