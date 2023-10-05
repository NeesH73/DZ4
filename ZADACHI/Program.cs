using System;
using System.Threading;

namespace ZADACHI
{
    internal class Program
    {
        static bool Perch(int[] array, int ch)
        {
            foreach(int i in array)
            {
                if (i==ch)
                { 
                    return true; 
                }
            }
            return false;
        }
        static int slow(ref int pr, out double arif, params int[] array)
        {
            int summ = 0;

            foreach (int number in array)
            {
                summ += number;
                pr *= number;
            }

            arif = (double)summ / array.Length;

            return summ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1: Поменять в массиве из 20 чисел 2 числа");
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i<array.Length;i++)
            {
                array[i] = rnd.Next();
            }
            if (int.TryParse(Console.ReadLine(), out int ch1) && int.TryParse(Console.ReadLine(), out int ch2))
            {
                if (Perch(array, ch1) && Perch(array, ch2))
                {
                    (array[ch1], array[ch2]) = (array[ch2], array[ch1]);
                    Console.WriteLine(array);
                }
                else
                {
                    Console.WriteLine("Таких чисел нет в массиве");
                }
            }
            else
            {
                Console.WriteLine("Введите числа");
            }


            Console.WriteLine("Задача 2: Написать метод для произведения, суммы, ср.ариф. ");
            int summ;
            double arif;
            int pr = 1;
            summ = slow(ref pr, out arif, array);
            Console.WriteLine($"Сумма - {summ}, произведение -{pr} , ср. ариф. - {arif}");


            Console.WriteLine("Задача 3: Написать цифры с помощью #");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int chislo))
                {
                    switch (chislo)
                    {
                        case 0:
                            Console.WriteLine("\t#####\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n");
                            break;
                        case 1:
                            Console.WriteLine("\t    #\n" +
                                              "\t  # #\n" +
                                              "\t #  #\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t    #\n");
                            break;
                        case 2:
                            Console.WriteLine("\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t#####\n" +
                                              "\t#    \n" +
                                              "\t#    \n" +
                                              "\t#####\n");
                            break;
                        case 3:
                            Console.WriteLine("\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t#####\n");
                            break;
                        case 4:
                            Console.WriteLine("\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t    #\n");
                            break;
                        case 5:
                            Console.WriteLine("\t#####\n" +
                                              "\t#    \n" +
                                              "\t#    \n" +
                                              "\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t#####\n");
                            break;
                        case 6:
                            Console.WriteLine("\t#####\n" +
                                              "\t#    \n" +
                                              "\t#    \n" +
                                              "\t#####\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n");
                            break;
                        case 7:
                            Console.WriteLine("\t######\n" +
                                              "\t#    #\n" +
                                              "\t    #\n" +
                                              "\t  #####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t    #\n");
                            break;
                        case 8:
                            Console.WriteLine("\t#####\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n");
                            break;
                        case 9:
                            Console.WriteLine("\t#####\n" +
                                              "\t#   #\n" +
                                              "\t#   #\n" +
                                              "\t#####\n" +
                                              "\t    #\n" +
                                              "\t    #\n" +
                                              "\t#####\n");
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nВы ввели число меньше 0 или больше 9!\n");
                            Thread.Sleep(3000);
                            Console.ResetColor(); ;
                            break;
                    }
                }
                else
                {
                    throw new Exception("Введите число");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }





        }
    }
}
