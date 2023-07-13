using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(number);

        Console.ReadLine();
    }

    static void PrintNumbers(int number)
    {
        if (number >= 1)
        {
            Console.WriteLine(number);
            PrintNumbers(number - 1);
        }
    }
}