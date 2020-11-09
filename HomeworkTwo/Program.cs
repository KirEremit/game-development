using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwo
{
    class Program
    {
        static void LessNum() //Написать метод, возвращающий минимальное из трех чисел.
        {
            Console.WriteLine("Введите первое число.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число.");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a < b && a < c)
            {
                Console.WriteLine("Первое число наименьшее.");
            }
            else if(b < a && b < c)
            {
                Console.WriteLine("Второе число наименьшее.");
            }
            else if(c < a && c < b)
            {
                Console.WriteLine("Третье число наименьшее");
            }
            else
            {
                Console.WriteLine("Введите разные числа");
            }
        }

        static void SumOfNum() //Написать метод подсчета количества цифр числа.
        {
            Console.WriteLine("Подсчёт количества цифр в числе.");
            Console.WriteLine("Введите целое число.");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Count = 0;

            while (Num > 0)
            {
                Count++;
                Num = Num / 10;
            }

            Console.WriteLine(Count);
        }

        static void PosNum() //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        {
            Console.WriteLine("Введите числа. Ноль выводит сумму всех нечетных положительных чисел.");
            int Num = 0; //Convert.ToInt32(Console.ReadLine());
            int Sum = 0;

            do
            {
                Num = int.Parse(Console.ReadLine());
                if (Num % 2 != 0 && Num >0)
                    Sum += Num;

            } while (Num != 0);

            Console.WriteLine(Sum);
        }

        static void Password() //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        {
            string Login = "root";
            string Password = "GeekBrains";
            int Count = 3;

            do
            {
                Console.WriteLine("Введите логин");
                string UserLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль.");
                string UserPassword = Console.ReadLine();
                
                if (Login == UserLogin && Password == UserPassword)
                {
                    break;
                }
                else
                {
                    Count--;
                    Console.WriteLine($"У вас осталось {Count} попыток");
                }
            } while (Count > 0);
            if (Count == 0) Environment.Exit(0);
        }
        
    static void Main()
        {
            Console.WriteLine("Кирилл Муромцев");
            Password();
            LessNum();
            SumOfNum();
            PosNum();
            
            Console.ReadKey();
        }
    }
}
