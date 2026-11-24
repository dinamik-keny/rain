using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число n: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n))
            {
                int result = CalculateDifference(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное целое число.");
            }
        }

        static int CalculateDifference(int n)
        {
            const int target = 123;
            int diff = Math.Abs(n - target);

            if (n > target)
            {
                return diff * 3;
            }

            return diff;
        }
    }
}
