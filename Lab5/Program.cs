using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countEl= 7;
            int[] mass = new int[countEl];
            float summ = 0;
            for (int i = 0; i < countEl; i++)
            {
                Console.WriteLine("Введите {0} значение",i+1);
                mass[i] = Convert.ToInt32(Console.ReadLine());
                summ += mass[i];
            }

            float average = summ / countEl;

            Console.WriteLine("среднее арифметическое {0,8:f2}", average);
            Console.ReadKey();


        }
    }
}
