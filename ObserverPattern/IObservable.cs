using System;
using System.Collections.Generic;
namespace DesignPatterns
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }


    public class WeatherSubject : ISubject
    {
        private List<IObserver> observers;
        private float _temperature;
        public float Temperature
        {
            get { return _temperature; }

            set
            {
                _temperature = value;
                Notify();
            }
        }
        public WeatherSubject()
        {
            observers = new List<IObserver>();
        }

        public void Notify()
        {
            observers.ForEach(o =>
            {
                o.Update(this);
            });
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

    }

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


