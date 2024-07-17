using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4.0);
        Console.WriteLine($"Square Color: {square.Color}, Area: {square.GetArea()}");

        Square square = new Square("Red", 4.0);
        Console.WriteLine($"Square Color: {square.Color}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 3.0, 5.0);
        Console.WriteLine($"Rectangle Color: {rectangle.Color}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle Color: {circle.Color}, Area: {circle.GetArea()}");

    }
}
