using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Operations
    {
        public static string ToStringWithIntegerPart(MyFrac f)
        {
            long integerPart = f.GetNom() / f.GetDen();
            long numerator = f.GetNom() % f.GetDen();
            long denominator = f.GetDen();

            if (numerator == 0)
            {
                return integerPart.ToString();
            }
            else if (integerPart == 0)
            {
                return $"{numerator}/{denominator}";
            }
            else
            {
                return $"({integerPart}+{Math.Abs(numerator)}/{denominator})";
            }
        }
        public static double DoubleValue(MyFrac F)
        {
            return (double)F.GetNom() / F.GetDen();

        }
        public static MyFrac Plus(MyFrac f1,MyFrac f2) 
        {
            long nom = f1.GetNom() * f2.GetDen() + f2.GetNom() * f1.GetDen();
            long denom = f1.GetNom() * f2.GetDen();
            return new MyFrac(nom, denom);
        }
        public static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            long denom = f1.GetDen() * f2.GetDen();

            long nom = f1.GetNom() * f2.GetDen() - f2.GetNom() * f1.GetDen();

            return new MyFrac(nom, denom);
        }

        public static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            long nom = f1.GetNom() * f2.GetNom();
            long denom = f1.GetDen() * f2.GetDen();
            return new MyFrac(nom, denom);
        }

        public static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            long nom = f1.GetNom() * f2.GetDen();
            long denom = f1.GetDen() * f2.GetNom();

            return new MyFrac(nom, denom);
        }
        public static MyFrac CalcSum1(int n)
        {
            MyFrac res = new MyFrac(1, 2);
            for (int i = 2; i <= n; i++)
            {
                MyFrac frac = new MyFrac(1, i * (i + 1));
                res = Plus(res, frac);
            }

            return res;
        }

        public static MyFrac CalcMul(int n)
        {
            MyFrac res = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                MyFrac frac = new MyFrac(i * i - 1, i * i);
                res = Multiply(res, frac);
            }


            return res;
        }

    }
}
