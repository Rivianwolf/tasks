using System;
public class exercise7
{
    public static void Main()  
    { 
        Console.WriteLine("Please enter num1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter num2:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
    }
}
