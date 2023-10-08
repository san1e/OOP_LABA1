using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class MatrixOperations
    {
        public static MatrixData Add(MatrixData matrix1, MatrixData matrix2)
        {
            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new ArgumentException("Матриці повинні бути одного розміру");
            }

            double[,] resultArray = new double[matrix1.Height, matrix1.Width];
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix1.Width; j++)
                {
                    resultArray[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return new MatrixData(resultArray);
        }

        public static MatrixData Mul(MatrixData matrix1, MatrixData matrix2)
        {
            if (matrix1.Width != matrix2.Height)
            {
                throw new ArgumentException("Матриці повинні мати одну кількість стовпчиків");
            }
            int resultRows = matrix1.Height;
            int resultCols = matrix2.Width;
            MatrixData result = new MatrixData(new double[resultRows, resultCols]);

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrix1.Width; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        private MatrixData matrixData;

        public MatrixOperations(MatrixData matrix)
        {
            this.matrixData = matrix;
        }
        private double[,] GetTransponedArray()
        {
            int rows = matrixData.Width;
            int cols = matrixData.Height;
            double[,] transposedArray = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedArray[i, j] = matrixData[j, i]; 
                }
            }

            return transposedArray;
        }

        public MatrixData GetTransponedCopy()
        {
            double[,] transposedArray = GetTransponedArray();
            return new MatrixData(transposedArray);
        }

        public void TransposeMe()
        {
            double[,] transposedArray = GetTransponedArray();
            matrixData = new MatrixData(transposedArray);
        }
    }
}
