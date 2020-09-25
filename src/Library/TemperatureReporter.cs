using System;

namespace Observer
{
    public class TemperatureReporter<T> : IObserver<T> where T : ITemperature
    {
        private bool first = true;

        private T last;
        
        private IObservable<T> provider;

        public void StartReporting(IObservable<T> provider)
        {
            this.provider = provider;
            this.first = true;
            this.provider.Subscribe(this);
        }

        public void StopReporting()
        {
            this.provider.Unsubscribe(this);
        }

        public void Update(T value)
        {
            Console.WriteLine($"The temperature is {value.Degrees}°C at {value.Date:g}");
            if (first)
            {
                last = value;
                first = false;
            }
            else
            {
                Console.WriteLine($"   Change: {value.Degrees - last.Degrees}° in " +
                    $"{value.Date.ToUniversalTime() - last.Date.ToUniversalTime():g}");
            }
        }
    }
}