using Pow_Without_POW;
using System;



 class Program

{

    static void Main(string[] args)
    {
        MATH math = new MATH();
        Console.Write("Enter the base number: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        Statuses statusi;

        double result = math.CustomPow(baseNumber, exponent, out statusi);


            Console.WriteLine("The result is: " + result);
            Console.WriteLine("The statusi is: " + statusi);


        Console.Write("Enter the base Number1: ");
        double Number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the base Number2: ");
        double Number2 = Convert.ToDouble(Console.ReadLine());

        Statuses minResultStatus;
        double minResult = math.Min(Number1, Number2, out minResultStatus);

            Console.WriteLine(minResultStatus + ":" + minResult);




        Console.Write("Enter the base MaxNumber1: ");
        double MaxNumber1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the base MaxNumber2: ");
        double MaxNumber2 = Convert.ToDouble(Console.ReadLine());

        Statuses maxResultStatus;
        double maxResult = math.Max(MaxNumber1, MaxNumber2, out maxResultStatus);

        Console.WriteLine(maxResultStatus + ":" + maxResult);

    }
}
