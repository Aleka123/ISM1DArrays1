using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1Func
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
        static double MaxElement(double []arr)
        {
            double Max = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > Max)
                    Max = arr[i];
                    return Max;
        }
        static double IMaxElement(double[] arr)
        {
            double Max = 0,I=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                    Max = arr[i]; I = i;
            }
            return I;
        }
        static double MaxAbsElement(double[] arr)
        {
            double AbsMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > AbsMax)//4.максимальний за модулем елемент масиву; 
                    AbsMax = (Math.Abs(arr[i]));
            }
            return AbsMax;
        }
        static double sumIDodElement(double[] arr)
        {
            double sumInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) //5.суму індексів додатних елементів; 
                    sumInd += i;
            }
            return sumInd;
        }
        static double sumIntElement(double[] arr)
        {
            double sumInt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 1 == 0)//6.кількість цілих чисел у масиві. 
                    sumInt += sumInt;
            }
            return sumInt;
        }



        static void Main(string[] args)
        {
            int count, min, max, prec;
            Console.Write("Count = ");
            count = int.Parse(Console.ReadLine());
            Console.Write("MinValue = ");
            min = int.Parse(Console.ReadLine());
            Console.Write("MaxValue = ");
            max = int.Parse(Console.ReadLine());
            Console.Write("Precision = ");
            prec = int.Parse(Console.ReadLine());
            double[] arr = GenerateArray(count, min, max, prec);
            Console.WriteLine("Array:");
            WriteArray(arr);
            double summa = SummaNegative(arr);
            Console.WriteLine("Summa = {0}", summa);
            double Max = MaxElement(arr);
            Console.WriteLine("Max = {0}", Max);
            double I = IMaxElement(arr);
            Console.WriteLine("I = {0}", I);
            double AbsMax = MaxAbsElement(arr);
            Console.WriteLine("AbsMax = {0}", AbsMax);
            double sumInd = sumIDodElement(arr);
            Console.WriteLine("sumInd = {0}", sumInd);
            double sumInt = sumIntElement(arr);
            Console.WriteLine("sumInt = {0}", sumInt);

        }
    }
}
