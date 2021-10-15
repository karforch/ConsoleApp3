using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Числа равны");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Второе число больше первого");
            }
            Console.ReadKey();
        }
    }
}
