using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Time              
            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeGmt = DateTime.Now;
            Console.WriteLine(currentDateTime.ToString());
            #endregion
            Console.ForegroundColor = ConsoleColor.Red;
            #region Info a,b on console
            // int a = 10, b = 30;
            // 
            // Console.WriteLine(" Hallo)\n a = " + a);
            // Console.WriteLine(" \n a = {0} \n b = {1}", a, b);
            //Console.WriteLine($"\n a = {a} \n b = {b}");
            #endregion
            #region Enter data from Keyboard

            //string str = Console.ReadLine();
            // int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(str);
            // Console.WriteLine(age + 10);
            //double price = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(price + "Hrn");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            //float f=float.Parse(Console.ReadLine());   
            //Console.WriteLine(f);   
            //double d = 3.6;
            // int a=




            #endregion

            #region if switch

            //double C = 10.5;
            //switch (C)
            {
                // case 1.3:
                //     Console.WriteLine("1.3");
                //         break;
                // case 1.0:
                //     Console.WriteLine("1.0");
                //     break;
            }


            #endregion

            #region LAB (1)
            Console.WriteLine("Задание 1");
            Console.WriteLine($"\n It's easy to win forgiveness for being wrong;\n being right is what gets you into realtrouble. \n Bjarne Stroustrup\n");

            #endregion

            #region LAB (2)
            Console.WriteLine("Задание 2\n");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum = {a+b+c+d+e},");
            Console.Write("Напишите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Напишите второе число:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Напишите третье число:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Напишите четвертое число:");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Напишите пятое число:");
            double e = double.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма всех чисел = {a + b + c + d + e}.");

            double max;
            if (a > b && a > c && a > d && a > e)
            {
                max = a;
                Console.WriteLine("Наибольшее число из всех - {0}.", max);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                max = b;
                Console.WriteLine("Наибольшее число из всех - {0}.", max);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                max = c;
                Console.WriteLine("Наибольшее число из всех - {0} ", max);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                max = d;
                Console.WriteLine("Наибольшее число из всех - {0}.", max);
            }
            else
            {
                max = e;
                Console.WriteLine("Наибольшее число из всех - {0}.", max);
            }

            double min;
            if (a < b && a < c && a < d && a < e)
            {
                min = a;
                Console.WriteLine("Наименьшее число из всех - {0}.", min);
            }
            else if (b < a && b < c && b < d && b < e)
            {
                min = b;
                Console.WriteLine("Наименьшее число из всех - {0}.", min);
            }
            else if (c < a && c < b && c < d && c < e)
            {
                min = c;
                Console.WriteLine("Наименьшее число из всех - {0} ", min);
            }
            else if (d < a && d < b && d < c && d < e)
            {
                min = d;
                Console.WriteLine("Наименьшее число из всех - {0}.", min);
            }
            else
            {
                min = e;
                Console.WriteLine("Наименьшее число из всех - {0}.", min);
            }
            Console.WriteLine($"Сумма всех чисел = {a * b * c * d * e}.\n");

            #endregion

            #region LAB (3)
            Console.WriteLine("Задание 3\n");
            Console.Write($"Напишите число: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write(A % 10);
            while ((A /= 10) != 0)
            {
                Console.Write(A % 10);
            }
            Console.WriteLine("\n-----------");
            //for (int i = A; i > -1; i--)
            //{
            //  Console.WriteLine("Фокус -> {0}", A);
            //}



            #endregion

            #region LAB (4)
            Console.WriteLine("Задание 4\n");
            //Console.WriteLine(" 1 номер элемента ряда Фибоначчи: ");
            //int fib1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2 номер элемента ряда Фибоначчи: ");
            //int fib2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число от 1 до ");
            int bis = int.Parse(Console.ReadLine());
            int von = 1;
            for (int i = 1; i <= bis; i += von)
            {
                Console.Write("{0} \n", i);
                von = i - von;
            }
            Console.WriteLine("\n");
            // Console.WriteLine("Номер элемента ряда Фибоначчи: ");
            // int n = int.Parse( Console.ReadLine() );

            //int num2 = 0;
            //Console.WriteLine(" Напишите первое число Фибоначи:");
            //int num0 = 0;// int.Parse(Console.ReadLine());
            //Console.WriteLine(" Напишите второе число Фибоначи:");
            // int num1 = 1; //int.Parse(Console.ReadLine());   
            // Console.WriteLine(" Напишите промежуточное число:");
            // int N = int.Parse( Console.ReadLine() );              
            



            #endregion

            #region LAB (5)

            Console.WriteLine("Задание 5\n");
            int l, r, spc, rows;
            Console.WriteLine("Введите количество строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (l = 1; l <= rows; l++)
            {
                for (r = 1; r <= l; r++)
                {
                    Console.Write("{0} ", l);
                }
                Console.Write("\n");
                spc--;
            }


            #endregion

            #region LAB (6)
            Console.WriteLine("Задание 6\n");

            Console.WriteLine("Введите число длины: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ: ");
            char sym = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите - h - для Горизонтального, - v - для вертикального направоения: ");
            char dir = char.Parse(Console.ReadLine());

            if (dir == 'h')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
            }

            else if (dir == 'v')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(sym);
                }
            }

            else
            {
                Console.WriteLine("Неправильно.");
            }

            #endregion
        }

    }
}
