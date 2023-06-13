using System;
namespace OddOrEven
{ 
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number you entered is odd");
            }
            else
                {
                Console.WriteLine("The number you entered is even");
                }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}