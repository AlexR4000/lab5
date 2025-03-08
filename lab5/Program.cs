using System;
using lab5;

public class Program
{
    public static void MakeCircle(double radius)
    {
        try
        {
            Circle circle = new Circle(radius);
            Console.WriteLine(circle.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Main(string[] args)
    {
        // Make circle for: 
        MakeCircle(25);   // 25 Invalid because over maxRadius
        MakeCircle(-20);  // Invalid radius (negative)
        MakeCircle(20);   // Valid radius
        MakeCircle(10);   // Valid radius
        MakeCircle(0);    // Valid radius
    }
}