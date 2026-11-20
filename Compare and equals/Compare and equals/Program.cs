using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_and_equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку (например, apple): ");
            string str1 = Console.ReadLine();

            Console.Write("Введите вторую строку (например, APPLE или banana): ");
            string str2 = Console.ReadLine();

            Console.WriteLine("\n--- 1. Операторы == и != ---");
            Console.WriteLine($"'{str1}' == '{str2}' : {str1 == str2}");
            Console.WriteLine($"'{str1}' != '{str2}' : {str1 != str2}");

            Console.WriteLine("\n--- 2. Метод Equals() ---");
            Console.WriteLine($"Equals (с учетом регистра): {str1.Equals(str2)}");
            Console.WriteLine($"Equals (без учета регистра): {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}");

            Console.WriteLine("\n--- 3. Метод Compare() ---");
            int compareRes = string.Compare(str1, str2);
            Console.WriteLine($"string.Compare('{str1}', '{str2}') = {compareRes}");

            Console.WriteLine("\n--- 4. Метод CompareOrdinal() ---");
            int ordinalRes = string.CompareOrdinal(str1, str2);
            Console.WriteLine($"string.CompareOrdinal('{str1}', '{str2}') = {ordinalRes}");

            Console.WriteLine("\n--- 5. Методы Contains() и IndexOf() ---");
            Console.Write("Введите предложение для поиска первой строки: ");
            string text = Console.ReadLine();

            bool isContained = text.Contains(str1);
            Console.WriteLine($"Содержит ли текст '{str1}' (Contains): {isContained}");

            int index = text.IndexOf(str1);
            if (index != -1)
            {
                Console.WriteLine($"Подстрока '{str1}' найдена на позиции (IndexOf): {index}");
            }
            else
            {
                Console.WriteLine($"Подстрока '{str1}' не найдена (IndexOf вернул -1)");
            }
        }
    }
}
