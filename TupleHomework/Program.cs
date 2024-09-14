using System;

class Program
{
    static (double perimeter, double area) Rectangle(double width, double height)
    {
        double perimeter = 2 * (width + height);
        double area = width * height;
        return (perimeter, area);
    }

    static (double perimeter, double area) Square(double side)
    {
        double perimeter = 4 * side;
        double area = side * side;
        return (perimeter, area);
    }

    static (double perimeter, double area) Triangle(double a, double b, double c)
    {
        double perimeter = a + b + c;

        double s = perimeter / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return (perimeter, area);
    }

    static void Main()
    {
        double rectWidth, rectHeight;
        while (true)
        {
            Console.Write("Enter width of rectangle: ");
            if (double.TryParse(Console.ReadLine(), out rectWidth) && rectWidth > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }

        while (true)
        {
            Console.Write("Enter height of rectangle: ");
            if (double.TryParse(Console.ReadLine(), out rectHeight) && rectHeight > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }

        var (rectPerimeter, rectArea) = Rectangle(rectWidth, rectHeight);
        Console.WriteLine($"Rectangle - Perimeter: {rectPerimeter}, Area: {rectArea}");

        double sqSide;
        while (true)
        {
            Console.Write("Enter side of square: ");
            if (double.TryParse(Console.ReadLine(), out sqSide) && sqSide > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }

        var (sqPerimeter, sqArea) = Square(sqSide);
        Console.WriteLine($"Square - Parameter: {sqPerimeter}, Area: {sqArea}");

        double triA, triB, triC;
        while (true)
        {
            Console.Write("Enter triA of triangle: ");
            if (double.TryParse(Console.ReadLine(), out triA) && triA > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }

        while (true)
        {
            Console.Write("Enter triB of triangle: ");
            if (double.TryParse(Console.ReadLine(), out triB) && triB > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }

        while (true)
        {
            Console.Write("Enter triC of triangle: ");
            if (double.TryParse(Console.ReadLine(), out triC) && triC > 0)
                break;
            Console.WriteLine("Invalid input, enter again.");
        }


        if (triA + triB > triC && triA + triC > triB && triB + triC > triA)
        {
            var (triPerimeter, triArea) = Triangle(triA, triB, triC);
            Console.WriteLine($"Triangle - Parameter: {triPerimeter}, Area: {triArea}");
        }
        else
        {
            Console.WriteLine("Invalid input to form a triangle, enter again.");
        }
    }
}
