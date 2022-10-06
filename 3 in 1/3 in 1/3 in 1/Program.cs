using System;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        int q = 0;
        while (q < 1)
        {

            Console.WriteLine("Выберите программу, которую вы хотите запустить");
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод деления чсисла");
            Console.WriteLine("4.Зарктыть программу");

            int vibor = int.Parse(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    Console.WriteLine("Вы выбрали первую программу");

                    Random rnd = new Random();
                    int myNUm;
                    int secret = rnd.Next(0, 100);
                    Console.WriteLine("Я загадал число от 1 до 100. Попробуй его угадать");
                    while (true)
                    {
                        myNUm = int.Parse(Console.ReadLine());
                        if (myNUm == secret)
                        {
                            Console.WriteLine("Вы угадали число");

                            break;
                        }
                        else
                        {
                            if (myNUm > secret)
                            {
                                Console.WriteLine("Меньше!");
                            }
                            else
                            {
                                Console.WriteLine("Больше!");
                            }

                        }

                    }
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали вторую программу");
                    var table = new int[10, 10];
                    for (int f = 0; f < 10; ++f)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            table[f, j] = f * j;
                        }
                    }
                    for (int f = 0; f < 10; ++f)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            Console.Write("{0, 3}", table[f, j]);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("Вы выбрали третью программу");

                    Console.Write("Введи число: ");
                    int i = int.Parse(Console.ReadLine());
                    for (int a = 1; a <= i; a++)
                    {
                        if (i % a == 0) Console.Write("{0} ", a);
                    }
                    break;

                case 4:
                    Console.WriteLine("Закрытие программы");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Вы выбрали несуществующую операцию ");
                    break;


            }

        }

        
    }
}