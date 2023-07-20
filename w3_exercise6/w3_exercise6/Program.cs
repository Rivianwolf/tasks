using System;
public class Exercise6
{ public static void Main()
    {
        int number1, number2, number3;

        Console.WriteLine("Please enter the first number:");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the second number:");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the third number:");
        number3 = Convert.ToInt32(Console.ReadLine());

        int result = number1 * number2 * number3;
        Console.WriteLine("Output: {0} x {1} x {2} = {3}", number1, number2, number3, result);
    }

}