using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class MatrixData
    {
        private double[,] matrix;
        public MatrixData(MatrixData other)
        {
            matrix = new double[other.Height, other.Width];
            for (int i = 0; i < other.Height; i++)
            {
                for (int j = 0; j < other.Width; j++)
                {
                    matrix[i, j] = other[i, j];
                }
            }
        }

        public MatrixData(double[,] arr)
        {
            int cols = arr.GetLength(1);
            int rows = arr.GetLength(0);
            matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = arr[i, j];
                }
            }
        }

        public MatrixData(double[][] arr)
        {   
            int rows = arr.Length;
            int cols = arr[0].Length;
            matrix = new double[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = arr[i][j];
                }
            }
        }

        public MatrixData(string[] rows)
        {
            int height = rows.Length;
            int width = rows[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            matrix = new double[height, width];
            for (int i = 0; i < height; i++)
            {
                string[] elements = rows[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = double.Parse(elements[j]);
                }
            }
        }
        // Конструктор з рядка
        public MatrixData(string matrixString)
        {
            string[] rows = matrixString.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int height = rows.Length;
            int width = rows[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            matrix = new double[height, width];
            for (int i = 0; i < height; i++)
            {
                string[] elements = rows[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = double.Parse(elements[j]);
                }
            }
        }
        // Властивості для отримання "висоти" та "ширини" матриці
        public int Height
        {
            get { return matrix.GetLength(0); }
        }

        public int Width
        {
            get { return matrix.GetLength(1); }
        }
        // Індексатори для доступу до елементів матриці
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
        // Перевизначений метод ToString для зручного виводу матриці
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sb.Append(matrix[i, j]);
                    if (j < Width - 1)
                    {
                        sb.Append("\t"); // Використовуємо табуляцію для розділення чисел в рядку
                    }
                }
                sb.AppendLine(); // Додаємо символ переведення рядка між рядками матриці
            }
            return sb.ToString();
        }
    }
}
