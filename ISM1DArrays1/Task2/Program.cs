using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, minAbs = 0, maxAbs = 0, dob = 1, firstMinus = -102, firstPlus = 102, secondPlus = 0, I = 0, i = 0, sum = 0, Dob = 1, firstZero = -1, lastZero = -1, I1 = 0, I2 = 0, I3 = 0, I4 = 0;
            double e = 1e-12;
            Console.Write("Введите N: ");
            Random rnd = new Random();
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Array: ");
            for (i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(-100, 101);
                Console.Write(arr[i] + (i == N - 1 ? "\n" : ", "));
            }
            { min = arr[0];
                for (i = 1; i < arr.Length; i++)
                    if (min > arr[i])//поч 2,1 
                    {
                        min = arr[i];
                        I = i;
                    }
                Console.WriteLine("I="+ I);
                        Console.WriteLine("min = " + min);
                {
                    for (i = I + 1; i < arr.Length; i++)
                        dob *= arr[i];
                }
             }   Console.WriteLine("dob = "+dob);
            //кінець 2,1

            {
                 for (i = 0; i < arr.Length; i++)//поч 2,2 
                    if (arr[i] < 0)
                    { firstMinus = arr[i]; I1 = i; break; }
            {
                    for (i = 0; i < arr.Length; i++)
                     if (arr[i] > 0){ firstPlus = arr[i];I = i; break; }
                 {
                        for (i = I+1; i < arr.Length; i++)
                            if (arr[i] > 0)
                            { secondPlus = arr[i]; I2 = i; break; }
                 }
              }
              }
            Console.WriteLine("firstMinus = " + firstMinus);
            Console.WriteLine("secondPlus = " + secondPlus);
            if ( I1<I2 )
            { for (i =I1  + 1; i < I2; i++)
                    sum += arr[i]; Console.WriteLine("sum = " + sum); }
            else
            if (I2 < I1)
            { for (i = I2 + 1; i < I1; i++)
                    sum += arr[i]; Console.WriteLine("sum = " + sum); }
            else
                Console.WriteLine("Виконання неможливе");
        //кінець 2,2  
                {for (i = 0; i < arr.Length; i++) //поч 2,3 
                    if (Math.Abs(arr[i]) < e)
                    {
                        firstZero = i; break;
                    }
                if (firstZero != -1)
                    for (i = arr.Length - 1; i > firstZero; i--)
                        if (Math.Abs(arr[i]) < e)
                        {
                            lastZero = i; break;
                        }
                if (firstZero == -1)
                    Console.WriteLine("Нулей нет");
                else
                if (lastZero == -1)
                    Console.WriteLine("Ноль только 1");
            }//кінець 2,3
               //поч 2,4
            {
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = Math.Abs(arr[i]);
                    Console.Write(arr[i] + (i == N - 1 ? "\n" : ", "));
                }
                {
                    minAbs = arr[0];
                    for (i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] < minAbs)
                        {
                            minAbs = arr[i]; I3 = i;
                        }
                    }
                } 
          }
                {
                    maxAbs = arr[0];
                    for (i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > maxAbs)
                        {
                            maxAbs = arr[i]; I4 = i;
                        }
                    }
                }
                {
                    if (I4 - I3 == 1 || I3 - I4 == 1)
                        Console.WriteLine("Найбiльше i найменше число стоять поруч, мiж ними немає елементiв масиву");
                    else
                       if (I3 < I4)
                    {
                        for (i = I3 + 1; i < I4; i++)
                        { Dob *= arr[i]; }
                    }
                    else
                        if (I4 < I3)
                        for (i = I4 + 1; i < I3; i++)
                            Dob *= arr[i];
                }
                Console.WriteLine("minAbs = " + minAbs);
                Console.WriteLine("I3 = " + I3);
                Console.WriteLine("maxAbs = " + maxAbs);
                Console.WriteLine("I4 = " + I4);
                Console.WriteLine("Dob=" + Dob);//кінець 2,4 
            }
        }
        }
    




