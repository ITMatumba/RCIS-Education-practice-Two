using System;     // код
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _2._6;

namespace Practica
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введиет 0, чтобы завершить программу.");
                Console.WriteLine("Введиет 1, чтобы узнать погоду в городе.");
                Console.Write("Введите номер операции: ");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Вы завершили работу программы");
                        return;
                    case 1:
                        Console.Write("Введиет название города чтобы узнать прогноз погоды: ");
                        string city = Console.ReadLine();
                        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&lang=ru&appid=bbd04c8362dfc0113aa0d7340acdfd4d&units=metric";
                        HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                        string response;

                        using (StreamReader streamReader = new StreamReader(Response.GetResponseStream()))
                        {
                            response = streamReader.ReadToEnd();
                        }
                        weather result = JsonConvert.DeserializeObject<weather>(response);

                        Console.WriteLine($"Погода в {result.Name}");
                        Console.WriteLine($"Температура: {result.Main.temp}°C");
                        Console.WriteLine($"Ощущается как: {result.Main.feels_like}");
                        Console.WriteLine($"{result.Weather[0].description}");
                        break;
                }
            }
        }
    }
}