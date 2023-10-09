using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class MyFrac
    {
        private long nom;
        private long denom;

        public long GetNom() { return nom; }
        public long GetDen() { return denom; }
        public void SetNom(long nom)
        {
            this.nom = nom;
        }
        public void SetDen(long denom)
        {
            this.denom = denom;
        }
        public MyFrac(long n, long d)
        {
            // Перевiрка на вiд'ємний знаменник та виправлення знакiв
            if (d < 0)
            {
                n = -n;
                d = -d;
            }

            // Знаходження найбiльшого спiльного дiльника (НСД)
            long gcd = FindGCD(Math.Abs(n), Math.Abs(d));

            // Скорочення дробу
            nom = n / gcd;
            denom = d / gcd;
        }

        // Метод для знаходження найбiльшого спiльного дiльника (НСД)
        private long FindGCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    } 
}
