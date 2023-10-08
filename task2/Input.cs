using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Input
    {
        public long Nom()
        {
            Console.Write("Введіть значення чисельника: ");
            long nom = long.Parse(Console.ReadLine());
            return nom;
        }
        public long Denom()
        {
            Console.Write("Введіть значення знаменника: ");
            long denom = long.Parse(Console.ReadLine());
            return denom;
        }

        public int N() 
        {
            Console.Write("Введіть значення N: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
