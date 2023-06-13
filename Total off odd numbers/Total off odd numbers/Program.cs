using System;
class TotalOffOddNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter  number");
        String input = Console.ReadLine();
        if (int.TryParse(input, out int number) )
        {
            int sum = 0;
            for (int i=1; i <= number; i +=2)
                        {
                            sum += i;                        
                        }
            Console.WriteLine("Total Sum of odd numbers from 1 to {0} is {1}", number, sum);
        }

    }

}