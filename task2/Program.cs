namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            MyFrac frac1 = new MyFrac(input.Nom(),input.Denom());
            Console.WriteLine();
            MyFrac frac2 = new MyFrac(input.Nom(),input.Denom());
            Console.Write("Дрiб 1: ");
            Console.WriteLine($"{frac1} = {Operations.DoubleValue(frac1)}");
            Console.WriteLine();
            Console.Write("Дрiб 2: ");
            Console.WriteLine($"{frac2} = {Operations.DoubleValue(frac2)}");
            Console.WriteLine();
            Console.Write("Додавання: ");
            Console.WriteLine($"{Operations.Plus(frac1,frac2)} = {Operations.DoubleValue(Operations.Plus(frac1,frac2))} ");
            Console.WriteLine();
            Console.Write("Вiднiмання: ");
            Console.WriteLine($"{Operations.Minus(frac1, frac2)} = {Operations.DoubleValue(Operations.Minus(frac1, frac2))} ");
            Console.WriteLine();
            Console.Write("Множення: ");
            Console.WriteLine($"{Operations.Multiply(frac1, frac2)} = {Operations.DoubleValue(Operations.Multiply(frac1, frac2))} ");
            Console.WriteLine();
            Console.Write("Дiлення: ");
            Console.WriteLine($"{Operations.Divide(frac1, frac2)} = {Operations.DoubleValue(Operations.Divide(frac1, frac2))} ");
            Console.WriteLine();
            int n = input.N();
            Console.Write("Вираз(1 / n * (n + 1): ");
            Console.WriteLine($"{Operations.CalcSum1(n)} = {Operations.DoubleValue(Operations.CalcSum1(n))} ");
            Console.Write("Вираз (1 - 1 / n^2): ");
            Console.WriteLine($"{Operations.CalcMul(n)} = {Operations.DoubleValue(Operations.CalcMul(n))} ");







        }
    }
}