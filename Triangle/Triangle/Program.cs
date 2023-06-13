using System;

class TriangleChecker
{
    static void Main()
    {
        Console.WriteLine("Enter side sizes:");
        Console.Write("Side A: ");
        double SideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side B: ");
        double SideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side C: ");
        double SideC = Convert.ToDouble(Console.ReadLine());

        if (IsTriangle(SideA, SideB, SideC))
        {
            Console.WriteLine("These numbers can form a triangle.");
        }
        else
        {
            Console.WriteLine("These numbers can't form a triangle.");
        }
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
