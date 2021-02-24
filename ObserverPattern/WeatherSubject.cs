using System.Collections.Generic;
namespace DesignPatterns
{
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
}


