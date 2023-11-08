using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"array[{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            sum += array[i, 3 - i];
        }
        Console.WriteLine("Сумма элементов на побочной диагонали: " + sum);

        int min = array[0, 0];
        int minIndexI = 0;
        int minIndexJ = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minIndexI = i;
                    minIndexJ = j;
                }
            }
        }
        Console.WriteLine("Индексы наименьшего элемента массива: [" + minIndexI + "," + minIndexJ + "]");
    }
}
