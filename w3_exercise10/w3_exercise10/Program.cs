public class Exercise9
{
    public static void Main()
    {
        double x, y, z;
        Console.WriteLine("Please enter x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter y:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter z:");
        z = Convert.ToDouble(Console.ReadLine());
        double result1 = (x + y) * z;
        double result2 = x * y + y * z;
        Console.WriteLine("The result of first is {0},{1},{2} is: {3}", x, y, z, result1);
        Console.WriteLine("The result of second is {0},{1},{2} is: {3}", x, y, z, result2);
    }
}


