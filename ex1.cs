using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        int m = 5;
        int n = 5;

        int[,] array = new int[m, n];

        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(-25, 16);
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t|");
            }
            Console.WriteLine();
        }

        int positiveCount = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] > 0)
                {
                    positiveCount++;
                }
            }
        }
        Console.WriteLine("Количество положительных элементов: " + positiveCount);

        int evenSum = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] % 2 == 0)
                {
                    evenSum += array[i, j];
                }
            }
        }
        Console.WriteLine("Сумма четных элементов: " + evenSum);
    }
}
