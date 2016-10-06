using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static double SummaNegative(double[] arr)
        {
            double summa = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    summa += arr[i];
            return summa;
        }
        static double[] GenerateArray(int size,
            int minValue, int maxValue, int precision)
        {
            double[] arr = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Math.Round(rnd.NextDouble() * (maxValue - minValue) +
                    minValue, precision);
            return arr;
        }
        static void WriteArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr[{0}] == {1}", i, arr[i]);
        }
        static void BubbleSort(double[] arr)
        {
            int i;
            double tmp;
            bool flag;
            do
            {
                flag = false;
                for (i = 0; i < arr.Length - 1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        flag = true;
                    }
            } while (flag);
        }







        static void Main(string[] args)
        {
            int count, min, max, prec;
            Stopwatch watch = new Stopwatch();
            Console.Write("Count = ");
            count = int.Parse(Console.ReadLine());
            Console.Write("MinValue = ");
            min = int.Parse(Console.ReadLine());
            Console.Write("MaxValue = ");
            max = int.Parse(Console.ReadLine());
            Console.Write("Precision = ");
            prec = int.Parse(Console.ReadLine());
            double[] arr, arrayForSorting;                                      // створюємо два масиви
            arr = GenerateArray(count, min, max, prec);                         // вводимо числа і генеруємо масив(арр)
            /*Console.WriteLine("Array:");
            WriteArray(arr);
            Console.WriteLine("Sorted Array:");*/
            arrayForSorting = (double[])arr.Clone();                            // копіюємо(клонуємо) масив(арр) отрмємо масив для сортування
            watch.Start();                                                      // запуск
            BubbleSort(arrayForSorting);
            watch.Stop();                                                       // зупинка
            Console.WriteLine("Bubble Sorting Time: {0}", watch.Elapsed);
            watch.Reset();
            arrayForSorting = (double[])arr.Clone();                            // копіюємо(клонуємо) масив(арр) отрмємо масив для сортування
            watch.Start();                                                      // запуск
            Array.Sort(arrayForSorting);
            watch.Stop();                                                       // зупинка
            Console.WriteLine(".NET Sorting Time: {0}", watch.Elapsed);
        }
    }
}
