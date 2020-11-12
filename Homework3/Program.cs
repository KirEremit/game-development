using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void ComplexExample()//Дописать структуру Complex, добавив метод вычитания комплексных чисел.
        {
            Complex a = new Complex();
            Complex b = new Complex();
            Complex result = new Complex();

            a.re = 2; a.im = 4;
            b.re = 2; b.im = 4;

            result = a.Minus(b);
            Console.WriteLine($"{result.re}re - {result.im}im.");

            result = a.Plus(b);
            Console.WriteLine($"{result.re}re + {result.im}im.");

            result = a.Multi(b);
            Console.WriteLine($"{result.re}re + {result.im}im.");
        }
        static void Numbers()//С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
        {
            Console.WriteLine("Введите число.\nВвод прекращается при введении нуля.\n");

            string Num;
            int Sum = 0;
            int x;
            bool result;

            do
            {
                Num = Console.ReadLine();
                result = int.TryParse(Num, out x);
                if (result)
                {
                    if (x > 0 && x % 2 != 0) Sum += x;
                }
                else
                {
                    Console.WriteLine("Некорректно введено число.");
                }
                
            } while (x != 0);

            Console.WriteLine($"Сумма нечётных чисел равна {Sum}");

        }
        static void Main()
        {
            Console.WriteLine("Кирилл Муромцев");
            ComplexExample();
            Numbers();

            Console.ReadKey();
        }
    }
}
