using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countEl = 15;
            int[] mass = new int[countEl];
            Random rnd = new Random();

            for (int i = 0; i < countEl; i++)
            {
                mass[i] = rnd.Next(0, 50);
                Console.Write(mass[i]+"  ");
            }

            int maxEl = mass[0];
            int minEl = mass[0];

            for (int i = 0; i < countEl; i++)
            {
                if (mass[i]>maxEl)
                {
                    maxEl = mass[i];
                }

                if (mass[i] < minEl)
                {
                    minEl = mass[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального {0}", minEl+maxEl);
            Console.ReadKey();

        }
    }
}
