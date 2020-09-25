namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {        
            TemperatureSensor<Temperature> sensor = new TemperatureSensor<Temperature>();
            TemperatureReporter<Temperature> reporter = new TemperatureReporter<Temperature>();
            reporter.StartReporting(sensor);
            sensor.GetTemperature();
        }
    }
}