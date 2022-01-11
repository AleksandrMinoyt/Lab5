using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент [{0},{1}]", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }

            //флаг одинаковости
            bool flag = true;

            int summ = 0;
            int summ2 = 0;

            //сумма первой строки
            for (int i = 0; i < n; i++)
            {
                summ += mass[0, i];
            }

            // суммы строк
            for (int i = 1; i < n; i++) // первую (0) строку попускаем, её уже считали
            {
                summ2 = 0;
                for (int j = 0; j < n; j++)
                {
                    summ2 += mass[i, j];
                }
                if (summ != summ2)
                {
                    flag = false;
                }
            }

            // суммы столбцов
            for (int i = 0; i < n; i++)
            {
                summ2 = 0;
                for (int j = 0; j < n; j++)
                {
                    summ2 += mass[j, i];
                }
                if (summ != summ2)
                {
                    flag = false;
                }
            }

            //сумма 1 диоганали
            summ2 = 0;
            for (int i = 0; i < n; i++)
            {
                summ2 += mass[i, i];
            }

            if (summ != summ2)
            {
                flag = false;
            }

            //сумма 2 диоганали
            summ2 = 0;
            for (int i = 0; i < n; i++)
            {
                summ2 += mass[i, n-i-1];
            }

            if (summ != summ2)
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("квадрат магичекий");
            }
            else
            {
                Console.WriteLine("квадрат НЕ магичекий");
            }
            Console.ReadKey();
        }
    }
}
