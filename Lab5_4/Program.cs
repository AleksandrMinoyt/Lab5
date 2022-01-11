using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countEl = 20;
            int[] mass = new int[countEl];
            Random rnd = new Random();

            int count = 0;

            for (int i = 0; i < countEl; i++)
            {
                mass[i] = rnd.Next(-50, 50);
                Console.Write(mass[i] + "  ");
                if ((((i + 1) % 2 == 0)) && (mass[i] % 2 != 0))
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нечетных элементов на четном месте {0}", count);
            Console.ReadKey();
        }
    }
}
