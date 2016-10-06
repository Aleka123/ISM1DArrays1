using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Max = 0, AbsMax = 0;
            int I = 0, i = 0, sumInt = 0, sum = 0, sumInd = 0; 
            Console.Write("Введите N: ");
            Random rnd = new Random();
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Array: ");
            for (i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(-100, 101);
                Console.Write(arr[i] + (i == N - 1 ? "\n" : ", "));
                if (arr[i] < 0) //1.суму від’ємних елементів масиву; 
                    sum += arr[i];
                if (arr[i] > Max)
                {
                    Max = arr[i]; //2.максимальний елемент масиву 
                    I = i;//3.номер (індекс) максимального елемента масиву; 
                }
                if (Math.Abs(arr[i]) > AbsMax)//4.максимальний за модулем елемент масиву; 
                    AbsMax = (Math.Abs(arr[i]));
                if (arr[i] > 0) //5.суму індексів додатних елементів; 
                    sumInd += i;
                if (arr[i] % 1 == 0)//6.кількість цілих чисел у масиві. 
                    sumInt+=sumInt;
            }
            Console.WriteLine("1) sum = " + sum);
            Console.WriteLine("2) max = " + Max);
            Console.WriteLine("3) I= " + I);
            Console.WriteLine("4) AbsMax = " + arr[I]);
            Console.WriteLine("5) sumInd = " + sumInd);
            Console.WriteLine("6) sumInt= " + sumInt);
       
        }
        }
    }


