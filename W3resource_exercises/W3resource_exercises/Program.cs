using System;
public class Exercise5
{
    public static void Main(string[] args)
    {
        int number1, number2, tempnumber;
        Console.WriteLine("Input first number:");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        number2 = int.Parse(Console.ReadLine());
        tempnumber = number1;
        number1 = number2;
        number2 = tempnumber;
        Console.Write("\n After Swapping : ");
        Console.Write("\nFirst Number : " + number1);
        Console.Write("\nSecond Number : " + number2);
        Console.Read();
    }

}