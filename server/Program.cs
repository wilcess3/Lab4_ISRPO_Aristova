using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать!");
        Console.WriteLine("ФИО: Аристова А.А");
        Console.WriteLine("Группа: ИСП-241");
        Console.WriteLine($"Дата и время: {DateTime.Now}");
        Console.WriteLine();
        Console.WriteLine("Меню:");
        Console.WriteLine("1 — Показать ФИО");
        Console.WriteLine("2 — Показать группу");
        Console.WriteLine("3 — Показать дату");
        Console.WriteLine("4 — Выход");
        Console.Write("Ваш выбор: ");

        string vibor = Console.ReadLine();

        if (vibor == "1")
        {
            Console.WriteLine("ФИО: Аристова А.А");
        }

        if (vibor == "2")
        {
            Console.WriteLine("Группа: ИСП-241");
        }

        if (vibor == "3")
        {
            Console.WriteLine("Дата: " + DateTime.Now);
        }

        if (vibor == "4")
        {
            Console.WriteLine("Выход...");
        }

        Console.ReadKey();
    }
}
