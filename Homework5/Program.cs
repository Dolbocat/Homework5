using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main()
        {

            bool f = true;

            while (f)
            {
                Console.Clear();
                Console.WriteLine("Тавризов Алексей, Домашняя работа 5");
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;
                                                
                    case 1:
                        Password();
                        Console.ReadLine();
                        break;

                    case 2:
                        Swap();
                        break;

                    case 3:
                        string a = "корова";
                        string b = "аоровк";
                        TextClass.Identical(a, b);
        
                                                    
                        Console.ReadLine();
                        
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        
                        break;

                    case 6:
                        
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;

                }              
            }
        }
        static void Password()
        {
            Console.WriteLine(@"Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
при этом цифра не может быть первой.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Введите логин: ");
            string password = Console.ReadLine();
            Regex regex = new Regex("^([A-z]|[0-9]){2,10}?$");
            regex.IsMatch(password);
            if (regex.IsMatch(password))
            {
                Console.WriteLine();
                Console.WriteLine("Вы ввели корректный логин, добро пожаловать!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Вы ввели неверный логин!");               
            }
        }

        static bool Swap()
        {
            return true;
        }
    }
}

