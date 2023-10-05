using System;
using System.Runtime.InteropServices;

namespace Tymakov5
{
    internal class Program
    {
        static int Max(int FN, int SN)
        {
            if (FN > SN)
            {
                return FN;
            }
            else
            {
                return SN;
            }
        }

        static void Mesta(int ch1, int ch2)
        {
            int prom = ch1;
            ch1 = ch2;
            ch2 = prom;
            Console.WriteLine($"Числа после обмена: {ch1}, {ch2}");
        }
        static bool Factorial(out int fact, int number)
        {
            try
            {
                fact = 1;

                for (int i = 1; i <= number; i++)
                {
                    checked
                    {
                        fact *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                fact = 0;
                return false;
            }
        }
        static int recFactorial(int num)
        {
            if (num == 1 || num==0)
            {
                return 1;
            }
            else
            {
                return num * recFactorial(num - 1);
            }
        }
        static int Nod(int a, int b)
        {
            int nd = 0;
            while(a!=b)
            {
                if(a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            nd = b;
            return nd;
        }
        static int Nod(int a,int b,int c)
        {
            if (a!=0 &&  b!=0 && c!=0)
            {
                return Nod(Nod(a, b), c);
            }
            else
            {
                return a + b + c;
            }
        }
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Упр 5.1: Вывести наиб.\n Введите два числа: ");
            if (int.TryParse(Console.ReadLine(),out int FN) && int.TryParse(Console.ReadLine(),out int SN))
            {
                Console.WriteLine($"Максимальное число из введенных: {Max(FN, SN)}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно.");
            }



            Console.WriteLine("Упражнение 5.2: Поменять местами\n Введите два числа: ");
            if (int.TryParse(Console.ReadLine(), out int ch1) && int.TryParse(Console.ReadLine(), out int ch2))
            {
                Console.WriteLine($"Числа до обмена: {ch1}, {ch2}");
                Mesta(ch1,ch2);
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }


            Console.WriteLine("Упражнение 5.3: Метод для вычисления факториала\n Введите число, факториал которого нужно найти: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (Factorial(out int fact, number))
                {
                    Console.WriteLine($"Факториал числа {number} равен {fact}");
                }
                else
                {
                    Console.WriteLine("Введите значение поменьше");
                }
            }
            else
            {
                Console.WriteLine("Данные введены некорректно.");
            }



            Console.WriteLine("Упраждение 5.4:рекурсивный метод для вычисления факториала\nВведите число для которого нужно найти факториал: ");
            if (int.TryParse(Console.ReadLine(), out int num) && recFactorial(num) != 0)
            {
                Console.WriteLine($"Факториал числа {num} равен {recFactorial(num)}");
            }
            else if (recFactorial(num) == 0)
            {
                Console.WriteLine("Введите числовое значение поменьше");
            }
            else
            {
                Console.WriteLine("Введите числовое значение");
            }




            Console.WriteLine("Домашнее задание 5.1:метод НОД \nВведите три числовых значения");
            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b) && int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine($"Наибольший общий делитель для чисел {a}, {b} и {c} равен {Nod(a,b,c)}");
                Console.WriteLine($"Наибольший общий делитель для чисел {a} и {b} равен {Nod(a,b)}");
                
            }
            else
            {
                Console.WriteLine("Введите числовые значения");
            }



            Console.WriteLine("Домашнее задание 5.2: метод для чисел Фибаначи \nВведите номер n числа ряда Фибоначчи: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"Номеру {n} соотвествует значение {Fib(n)}");
            }
            else
            {
                Console.WriteLine("Введите числовое значение");
            }
        }
    }
}
