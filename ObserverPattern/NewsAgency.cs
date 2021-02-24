using System;
namespace DesignPatterns
{
    public class NewsAgency : IObserver
    {
        public NewsAgency(string name)
        {
            AgencyName = name;
        }

        public string AgencyName { get; set; }

        public void Update(ISubject subject)
        {
            WeatherSubject station = subject as WeatherSubject;
            if (station != null)
            {
                Console.WriteLine($"{AgencyName} Reporting temperature {station.Temperature} degree celsius ");
            }
        }
    }
}


