//задание 1
/*using _2._2;
using System;
class Program
{
    static void Main()
    {
        int studentcount = 0;
        Student[] students = new Student[5];
        Random rand = new Random();
        while (true)
        {
            Console.WriteLine("\nВведите число 1, что бы добавить студента");
            Console.WriteLine("Введите число 2, что бы напечатать студента");
            Console.WriteLine("Введите число 0, что бы завершить программу");
            Console.Write("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine()!);
            switch (num)
            {
                case 0:
                    return;
                case 1:
                    if (studentcount == 5)
                    {
                        Console.WriteLine("Больше не возможно добавить студентов");
                        break;
                    }
                    Student student = new Student();
                    Console.Write("Введите фамилию и имя студента: ");
                    student.surname = Console.ReadLine()!;
                    Console.Write("Введите дату рождения студента: ");
                    student.dateOfBirthday = Convert.ToDateTime(Console.ReadLine()!);
                    Console.Write("Введите номер группы студента: ");
                    student.numbers = int.Parse(Console.ReadLine()!);
                    for (int i = 0; i < student.marks.Length; i++)
                    {
                        student.marks[i] = rand.Next(2, 5);
                    }
                    students[studentcount] = student;
                    studentcount++;
                    break;
                case 2:
                    for (int i = 0; i < studentcount; i++)
                    {
                        Console.WriteLine($"Фамилия и имя студента: {students[i].surname}");
                        Console.WriteLine($"Дата рождения: {students[i].dateOfBirthday.ToShortDateString()}");
                        Console.WriteLine($"Номер группы: {students[i].numbers}");
                        Console.WriteLine($"Успеваемость: {string.Join(", ", students[i].marks)}");
                    }
                    break;
            }
        }
    }
}*/

/*using System; //задание 2

namespace _2._2
{
    class Program
    {
        static void Main()
        {
            Train train1 = new Train();

            train1.points = "Москва";
            train1.number = 156;
            train1.time = "12:00";

            Train train2 = new Train();

            train2.points = "Томск";
            train2.number = 503;
            train2.time = "18:00";

            Train train3 = new Train();

            train3.points = "Сочи";
            train3.number = 101;
            train3.time = "22:00";

            Train trains = new Train();

            Console.Write("Введите номер поезда, чтобы узнать о нем информацию: ");
            trains.number = int.Parse(Console.ReadLine());

            switch (trains.number)
            {
                case 156:
                    Console.Write($"Поезд под номером {train1.number} отправляется в {train1.points} в {train1.time}");
                    break;
                case 503:
                    Console.Write($"Поезд под номером {train2.number} отправляется в {train2.points} в {train2.time}");
                    break;
                case 101:
                    Console.Write($"Поезд под номером {train3.number} отправляется в {train3.points} в {train3.time}");
                    break;
            }
        }
    }
}*/

//using System;   //задание 3
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using _2._2;

//class Program
//{
//    static void Main()
//    {
//        Numbers number = new Numbers(0, 0);
//        while (true)
//        {
//            Console.WriteLine("Введите число 0 чтобы закончить программу.");
//            Console.WriteLine("Введите число 1 чтобы измеить числа");
//            Console.WriteLine("Введите число 2 чтобы вывести числа");
//            Console.WriteLine("Введите число 3 чтобы найти сумму чисел");
//            Console.WriteLine("Введите число 4 чтобы найти максимальное число");
//            int chislo = int.Parse(Console.ReadLine());
//            switch (chislo)
//            {
//                case 0:
//                    Console.WriteLine("Программа завершена");
//                    return;
//                case 1:
//                    Console.Write("Введите Перове число: ");
//                    int nums1 = int.Parse(Console.ReadLine());
//                    Console.Write("Введите Второе число: ");
//                    int nums2 = int.Parse(Console.ReadLine());
//                    number.changOfNumbers(nums1, nums2);
//                    break;
//                case 2:
//                    number.conclusionOfNumbers();
//                    break;
//                case 3:
//                    Console.WriteLine($"Сумма чисел: {number.sumOfNumbers()}");
//                    break;
//                case 4:
//                    Console.WriteLine($"Наибольшее число: {number.maxOfNumbers()}");
//                    break;
//            }
//        }
//    }
//}

/*using System;  //Задание 4
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2._2;

class Program
{
    static void Main()
    {
        counter count = new counter();
        Random rand = new Random();

        while (true)
        {
            Console.WriteLine("Введите число 0, чтобы завершить работу счетсчика.");
            Console.WriteLine("Введите число 1, чтобы уменьшить значение счетчика.");
            Console.WriteLine("Введите число 2, чтобы увеличить значение счетчика.");
            Console.WriteLine("Введите число 3, чтобы вывести значение счетчика.");
            Console.WriteLine("Введите число 4, чтобы счетчик произвольное значение.");
            Console.WriteLine("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());
            int number = 0;

            switch (num)
            {
                case 0:
                    Console.WriteLine("Вы завершили работу программу.");
                    return;
                case 1:
                    count.shetchickOfLow();
                    break;
                case 2:
                    count.shetchickOfSum();
                    break;
                case 3:
                    Console.WriteLine(count.Output);
                    break;
                case 4:
                    number = rand.Next();
                    count = new counter(number);
                    break;
            }
        }
    }
}*/

/*using System;  //задание 5
using System.Collections.Generic;
using System.Text;
using System.Linq;
using _2._2;

class Program
{
    static void Main()
    {
        NamesSurname people = new NamesSurname();
        while (true)
        {
            Console.WriteLine("Введите число 0, чтобы завершить работу программы.");
            Console.WriteLine("Введите число 1, чтобы ввести имя и фамилию");
            Console.WriteLine("Введите число 2, чтобы показать данные");
            Console.Write("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.Write("Введите Имя: ");
                    String name1 = Console.ReadLine();
                    Console.Write("Введите Фамилию: ");
                    String name2 = Console.ReadLine();
                    people = new NamesSurname(name1, name2);
                    break;
                case 2:
                    Console.WriteLine(people.name);
                    Console.Write(people.surname);
                    break;
            }
        }
    }
}*/
