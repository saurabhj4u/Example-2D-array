//example 2D array
using System;

class A
{
    public static void Main()
    {
        int[,] a = new int[3, 4];
        int i, j;
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 4; j++)
            {
                Console.WriteLine("Enter matrix elements");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("output matrix:-");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 4; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }
}
