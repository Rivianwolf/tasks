using System;
class SquareNumber
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        String input = Console.ReadLine();
        double.TryParse(input, out double number);
        {
            double square = Math.Pow(number, 2);
            Console.WriteLine("The Square of {0} number is {1}", number, square);
        }
    }
}