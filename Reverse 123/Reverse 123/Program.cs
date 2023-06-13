using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            List<int> list = new List<int>();
            var zz = sum(number, list);

            Console.WriteLine(zz);


        }

        static int sum(int x, List<int> list)
        {
            List<int> meore = list;
            int x1 = x;
            list.Add(x1);
            return x1;

        }




    }
}