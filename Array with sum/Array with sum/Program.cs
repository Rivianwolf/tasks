    using System;
    class arraySizeCounter
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arraySize = new int[size];
            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Element {0}:", i + 1);
                arraySize[i] = Convert.ToInt32(Console.ReadLine());
            }
        int sum = 0;
        foreach (int item in arraySize)
        {
            sum += item;
        }
        Console.WriteLine("Total: " + sum);
            
        }
    }


