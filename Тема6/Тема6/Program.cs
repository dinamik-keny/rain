using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Parse() — преобразует строку в стандартном формате
            DateTime date1 = DateTime.Parse("06.01.2022");
            DateTime dateTime1 = DateTime.Parse("20.07.2015 18:30:25");
            Console.WriteLine($"Parse: {date1.ToLongDateString()} и {dateTime1:G}");

            // 2. ParseExact() — преобразует строку по строго заданному шаблону описателей
            DateTime date2 = DateTime.ParseExact("2022/07/20", "yyyy/MM/dd", CultureInfo.InvariantCulture);
            DateTime dateTime2 = DateTime.ParseExact("20-07-2015 18.30", "dd-MM-yyyy HH.mm", CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact: {date2:dd.MM.yyyy} и {dateTime2:F}");

            // 3. TryParse() — безопасное преобразование без выброса исключения при ошибке
            Console.Write("\nВведите дату и время (например, 20.07.2015 14:45): ");
            string inputTime = Console.ReadLine();

            if (DateTime.TryParse(inputTime, out DateTime parsedDateTime))
            {
                Console.WriteLine($"Успешно (TryParse): {parsedDateTime.ToShortTimeString()}");
            }
            else
            {
                Console.WriteLine("Ошибка TryParse: неверный формат даты или времени.");
            }

            // 4. TryParseExact() — безопасное преобразование по строгому формату
            Console.Write("\nВведите дату строго в формате дд-мм-гггг (например, 25-12-2026): ");
            string inputDate = Console.ReadLine();

            if (DateTime.TryParseExact(
                inputDate,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedDate))
            {
                DateTime nextDay = parsedDate.AddDays(1);
                Console.WriteLine($"Успешно (TryParseExact): {parsedDate.ToLongDateString()}");
                Console.WriteLine($"Следующий день: {nextDay.ToShortDateString()} ({nextDay.DayOfWeek})");
            }
            else
            {
                Console.WriteLine("Ошибка TryParseExact: дата не соответствует шаблону dd-MM-yyyy.");
            }
        }
    }
}
