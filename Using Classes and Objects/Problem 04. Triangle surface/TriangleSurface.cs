//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;

using System;

class TriangleSurface
{
    static double Surface(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    static double Surface(double side1, double side2, double side3)
    {
        double p = (side1 + side2 + side3) / 2;
        double s = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        return s;
    }


    static double Surface(double side1, double side2, int degrees)
    {
        double s = (side1 * side2 * Math.Sin(degrees * Math.PI / 180)) / 2;
        return s;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("{0:F2}", Surface(23.2d, 5.0d));
        Console.WriteLine("{0:F2}", Surface(11.0d, 12.0d, 13.0d));
        Console.WriteLine("{0:F2}", Surface(10.0d, 7.0d, 25));
        
  }
}

