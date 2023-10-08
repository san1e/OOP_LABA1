using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Input
    {
        public double[,] Arr()
        {
            Console.WriteLine("Введiть розмiр матрицi (і х j)");
            int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            double[,] array = new double[size[0], size[1]];

            Console.WriteLine("Введіть елементи масиву:");

            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write($"Елемент [{i}, {j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public double[][] Arr2() 
        {
            Console.WriteLine("Введіть розмірність рядків:");
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Введіть кількість елементів у рядку {i + 1}:");
                int columns = int.Parse(Console.ReadLine());

                jaggedArray[i] = new double[columns];

                Console.WriteLine($"Введіть елементи для рядку {i + 1} (через пробіл):");
                string[] elements = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    jaggedArray[i][j] = int.Parse(elements[j]);
                }
            }
            return jaggedArray;
        }

        public string[] Arr3()
        {
            Console.WriteLine("Введіть кількість рядків у матриці:");
            int rowCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість чисел у кожному рядку:");
            int colCount = int.Parse(Console.ReadLine());

            string[] rows = new string[rowCount];

            Console.WriteLine("Введіть числа для кожного рядка, розділені пробілами або табуляціями:");

            for (int i = 0; i < rowCount; i++)
            {
                Console.Write($"Рядок {i + 1}: ");
                rows[i] = Console.ReadLine();
            }
            return rows;
        }

        public string Arr4()
        {
            Console.WriteLine("Введіть матрицю рядок за рядком, розділяючи елементи пробілами або табуляцією.");
            Console.WriteLine("Введіть порожній рядок, щоб завершити введення.");
            string input = "";
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                    break;
                input += line + "\n";
            }
            return input;
        }
    }
}
