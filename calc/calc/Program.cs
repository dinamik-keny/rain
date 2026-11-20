using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 250, 500, 0 };

            Console.Write("Введите индекс элемента массива (от 0 до 3): ");
            string indexInput = Console.ReadLine();

            Console.Write("Введите делитель: ");
            string divisorInput = Console.ReadLine();

            if (!int.TryParse(indexInput, out int index) || !int.TryParse(divisorInput, out int divisor))
            {
                Console.WriteLine("Ошибка ввода: необходимо ввести целые числа.");
                return;
            }

            try
            {
                int selectedNumber = numbers[index];
                int result = selectedNumber / divisor;

                Console.WriteLine($"Результат деления {selectedNumber} на {divisor} равен: {result}");
            }
            catch (DivideByZeroException) when (numbers[index] != 0)
            {
                Console.WriteLine("Ошибка: нельзя делить ненулевое число на ноль!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Математическая ошибка: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка индексации: {ex.Message}");
                Console.WriteLine($"Метод вызвавший ошибку: {ex.TargetSite}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденное исключение: {ex.Message}");
                Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Выполнение операции завершено (блок finally).");
            }
        }
    }
}
