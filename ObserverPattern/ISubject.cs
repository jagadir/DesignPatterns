namespace DesignPatterns
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Notify();
    }
}


