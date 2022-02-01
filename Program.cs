using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №1. Задание 2";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            double x, a, b, f, fx;
            Console.Write("Введите значение a:");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Введите значение b:");
            b = Double.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.Write("Границы интервала введены неверно");
            }
            else
            {
                Console.Write(" Шаг: ");
                double deltax = Double.Parse(Console.ReadLine());
                a += deltax;
                x = a;
                int i = 1;
                Console.WriteLine();
                while (x <= b)
                {
                    if (x <= 2)
                    {
                        f = Math.Pow(x, 2) + 4 * x + 5;
                        Console.WriteLine(" x(" + i + ") = " + x + "; f(x) = " + f);
                    }
                    else
                    {
                        f = Math.Pow(x, 2) + 4 * x + 5;
                        fx = 1 / f;
                        Console.WriteLine(" x(" + i + ") = " + x + "; f(x) = " + fx);
                    }
                    x += deltax;
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
