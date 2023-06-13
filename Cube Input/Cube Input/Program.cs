using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Cubes of numbers:");
            for (int i = 1; i <= number; i++)
            {
                int cube = (int)Math.Pow(i, 3);
                Console.WriteLine("Cube of {0}: {1}", i, cube);
            }
        }
    }
}
