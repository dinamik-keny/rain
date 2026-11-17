using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomLib;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2
            User customer = new User();
            customer.name = "Алексей";
            customer.age = 25;
            customer.email = "alexey@example.com";
            customer.isOnline = true;

            customer.PrintUserInfo();
            customer.ShowSecurityStatus();

            Console.WriteLine(new string('-', 40));

            // Задания 2 и 3
            LibraryOperations lib = new LibraryOperations();

            lib.SayWelcome();
            lib.PrintMessage("Проверка передачи текста в метод библиотеки.");

            int sumResult = lib.Add(15, 27);
            Console.WriteLine($"Результат сложения (Add): {sumResult}");

            double divResult = lib.Dev(100, 4);
            Console.WriteLine($"Результат деления (Dev): {divResult}");

            string greeting = lib.FormatUserGreeting(customer.name, 500);
            Console.WriteLine(greeting);

            Console.ReadKey();
        }
    }
}
