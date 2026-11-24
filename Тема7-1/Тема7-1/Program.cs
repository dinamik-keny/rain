using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 15, 3, 28, 7, 11 };
            int[] secondArray = { 42, 1, 19 };

            // 1. Объединение двух массивов в один
            int[] merged = MergeArrays(firstArray, secondArray);
            Console.WriteLine("Объединённый массив: " + string.Join(", ", merged));

            // 2. Сортировка по возрастанию
            Array.Sort(merged);
            int[] sortedMerged = merged;
            Console.WriteLine("По возрастанию:      " + string.Join(", ", merged));

            // 3. Сортировка по убыванию
            Array.Reverse(sortedMerged);
            Console.WriteLine("По убыванию:         " + string.Join(", ", sortedMerged));
        }

        // Метод объединения двух массивов в один
        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            Array.Copy(array1, 0, result, 0, array1.Length);
            Array.Copy(array2, 0, result, array1.Length, array2.Length);
            return result;
        }
    }
}
