using System;
namespace MyCustomLib
{
    // --- ЗАДАНИЕ 2 ---
    public class User
    {
        public string name = "Неизвестно";
        public string email = "Нет почты";
        public int age;
        public bool isOnline;

        private string secretPassword = "12345_SecretPassword";

        public void PrintUserInfo()
        {
            Console.WriteLine($"Пользователь: {name}, Возраст: {age}, Email: {email}, В сети: {isOnline}");
        }

        private string GetMaskedPassword()
        {
            return "********";
        }

        public void ShowSecurityStatus()
        {
            Console.WriteLine($"Пароль пользователя {name} защищен: {GetMaskedPassword()}");
        }
    }

    // --- ЗАДАНИЕ 2 и ЗАДАНИЕ 3: Методы для DLL ---
    public class LibraryOperations
    {
        // 1. Метод без параметров
        public void SayWelcome()
        {
            Console.WriteLine("Добро пожаловать! Библиотека DLL успешно подключена.");
        }

        // 2. Метод с параметром
        public void PrintMessage(string message)
        {
            Console.WriteLine($"[Сообщение из DLL]: {message}");
        }

        // 3. Задание 2: сложение Add
        public int Add(int x, int y)
        {
            return x + y;
        }

        // 4. Задание 2: деление Dev
        public double Dev(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return x / y;
        }

        // 5. 3-й тип возврата для Задания 3
        public string FormatUserGreeting(string userName, int bonusPoints)
        {
            return $"Привет, {userName}! На вашем счету {bonusPoints} бонусных баллов.";
        }

        // 6. Метод с модификатором internal
        internal void InternalHelper()
        {
            Console.WriteLine("Этот метод виден только внутри проекта MyCustomLib.");
        }
    }
}
