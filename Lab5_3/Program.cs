using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countEl = 10;
            int[] mass = new int[countEl];
            Random rnd = new Random();

            for (int i = 0; i < countEl; i++)
            {
                mass[i] = rnd.Next(-50, 50);
                Console.Write(mass[i] + "  ");
            }

          
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (mass[i]>mass[j])
                    {
                        int temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }

            for (int i = 5; i < countEl; i++)
            {
                for (int j = i + 1; j < countEl; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        int temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < countEl; i++)
            {               
                Console.Write(mass[i] + "  ");
            }


            Console.ReadKey();
        }
    }
}
