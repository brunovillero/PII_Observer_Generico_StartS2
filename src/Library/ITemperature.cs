using System;
namespace Observer
{
    public interface ITemperature
    {
        decimal Degrees {get;}
        DateTime Date {get;}
    }
}