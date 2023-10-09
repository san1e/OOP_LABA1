namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input inp = new Input();
            double[,] arr1 = inp.Arr();

            MatrixData matrix1 = new MatrixData(arr1);
            Console.WriteLine("Матриця1:");
            Console.WriteLine(matrix1);
            Console.WriteLine();

            //double[][] arr2 = inp.Arr2();

            //MatrixData matrix2 = new MatrixData(arr2);
            //Console.WriteLine("Матриця2:");
            //Console.WriteLine(matrix2);
            //Console.WriteLine();

            //string[] arr3 = inp.Arr3();

            //MatrixData matrix3 = new MatrixData(arr3);
            //Console.WriteLine("Матриця3:");
            //Console.WriteLine(matrix3);
            //Console.WriteLine();

            //string arr4 = inp.Arr4();

            //MatrixData matrix4 = new MatrixData(arr4);
            //Console.WriteLine("Матриця4:");
            //Console.WriteLine(matrix4);
            //Console.WriteLine();

            //Console.WriteLine("+");
            //MatrixData result1 = MatrixOperations.Add(matrix1, matrix2);
            //Console.WriteLine(result1);

            //Console.WriteLine("*");
            //MatrixData result2 = MatrixOperations.Mul(matrix1, matrix2);
            //Console.WriteLine(result2);

            MatrixOperations matrixOps = new MatrixOperations(matrix1);
            MatrixData transposedCopy = matrixOps.GetTransponedCopy();
            matrixOps.TransposeMe();
            Console.WriteLine("Транспонована матриця");
            Console.WriteLine(transposedCopy);

        }
    }
}