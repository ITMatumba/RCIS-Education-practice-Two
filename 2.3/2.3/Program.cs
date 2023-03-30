/*using System;  // Задание 1
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2._3;

class Program
{
    static void Main()
    {
        Worker people = new Worker();

        while (true)
        {
            Console.WriteLine("\nНажмите на 0, чтобы завершить работу программы.");
            Console.WriteLine("Нажмите 1, чтобы ввести данные о рабочем.");
            Console.WriteLine("Нажмите 2, чтобы ввести ставку за один рабочий день.");
            Console.WriteLine("Нажмите 3, чтобы ввести кол-во отработанных дней.");
            Console.WriteLine("Нажмите 4, чтобы вывести информацию о рабочем.");
            Console.WriteLine("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.Write("Вы завершили программу.");
                    return;
                case 1:
                    Console.Write("Введите имя рабочего: ");
                    people.name = Console.ReadLine();
                    Console.Write("Введите фамилию рабочего: ");
                    people.surname = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введите ставку за один рабочий день: ");
                    people.rate = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Введите кол-во отработанных дней: ");
                    people.days = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine($"Имя и фамилия: {people.name} {people.surname}");
                    Console.WriteLine($"Ставка: {people.rate}");
                    Console.WriteLine($"Отработанно: {people.days} дня(дней)");
                    Console.WriteLine($"Зарплата: {people.GetSalary()} руб.");
                    break;
            }
        }
    }
}*/

/*using System;  //Задание 2
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2._3;

class Program
{
    static void Main()
    {
        Workers people = new Workers();

        while (true)
        {
            Console.WriteLine("\nНажмите на 0, чтобы завершить работу программы.");
            Console.WriteLine("Нажмите 1, чтобы ввести данные о рабочем.");
            Console.WriteLine("Нажмите 2, чтобы ввести ставку за один рабочий день.");
            Console.WriteLine("Нажмите 3, чтобы ввести кол-во отработанных дней.");
            Console.WriteLine("Нажмите 4, чтобы вывести информацию о рабочем.");
            Console.WriteLine("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.Write("Вы завершили программу.");
                    return;
                case 1:
                    Console.Write("Введите имя рабочего: ");
                    people.Name = Console.ReadLine();
                    Console.Write("Введите фамилию рабочего: ");
                    people.Surname = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введите ставку за один рабочий день: ");
                    people.Rate = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Введите кол-во отработанных дней: ");
                    people.Days = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine($"Имя и фамилия: {people.Name} {people.Surname}");
                    Console.WriteLine($"Ставка: {people.Rate}");
                    Console.WriteLine($"Отработанно: {people.Days} дня(дней)");
                    Console.WriteLine($"Зарплата: {people.GetSalary()} руб.");
                    break;
            }
        }
    }
}*/

/*using System;    // Задание 3
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2._3;

class Program
{
    static void Main()
    {
        Calculation symbol = new Calculation();
        while (true)
        {
            Console.WriteLine("Нажмите 0, чтобы завершить работу программы.");
            Console.WriteLine("Нажмите 1, чтобы внести измененени.");
            Console.WriteLine("Нажмите 2, чтобы добавить символ в конце строки.");
            Console.WriteLine("Нажмите 3, чтобы вывести значения.");
            Console.WriteLine("Нажмите 4, чтобы Вывести последний символ.");
            Console.WriteLine("Нажмите 5, чтобы удалить последний символ.");
            Console.Write("Введите номер операции: ");
            int unswer = Convert.ToInt32(Console.ReadLine());
            switch (unswer)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.WriteLine("Введите измененный вариант: ");
                    symbol.SetCalculationLine = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Новый символ: ");
                    string newSymbol = Console.ReadLine();
                    symbol.SetLastSymbolCalculationLine(newSymbol);
                    break;
                case 3:
                    Console.WriteLine("Предложение: ");
                    string justSentence = symbol.calculationLine;
                    Console.WriteLine(symbol.GetCalculationLine);
                    break;
                case 4:
                    Console.WriteLine("Последний символ: ");
                    Console.WriteLine(symbol.GetLastSymbol());
                    break;
                case 5:
                    Console.WriteLine("Предложение после удаления: ");
                    Console.WriteLine(symbol.DeleteLastSymbol());
                    break;
            }
        }
    }
}*/

