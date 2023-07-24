public class Exercise9
{
    public static void Main()
    {
        double x, y, z, w;
        Console.WriteLine("Please enter x:");
            x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter y:");
            y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter z:");
            z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter w:");
            w = Convert.ToDouble(Console.ReadLine());
        double avg = (x+y+z+w)/4;
        Console.WriteLine("The Average of {0},{1},{2},{3} is: {4}", x, y, z, w, avg);
    }
}