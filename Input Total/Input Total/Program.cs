using System;

class Total
{
    static void Main()
    {
        Console.WriteLine("Please enter number:");
        String input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            int total = 0;
            for (int i = 1; i <= number; i++)
            {
                total += i;
            }

            Console.WriteLine("The total of numbers from 1 to {0} is: {1}", number, total);
        }
    }
}