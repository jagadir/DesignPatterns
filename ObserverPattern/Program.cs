using System;
using DesignPatterns;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherSubject sub1 = new WeatherSubject();

            NewsAgency agency1 = new NewsAgency("Tv9");
            sub1.Subscribe(agency1);

            NewsAgency agency2 = new NewsAgency("Public");
            sub1.Subscribe(agency2);

            sub1.Temperature = 24f;
            sub1.Temperature = 32f;
            sub1.Temperature = 45f;
            sub1.Temperature = 15f;
            
            Console.WriteLine("Hello World!");

        }
    }
}
