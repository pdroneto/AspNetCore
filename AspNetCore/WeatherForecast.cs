using System;

namespace AspNetCore
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureCelsius { get; set; }

        public int TemperaturaF => 32 + (int)(TemperatureCelsius / 0.5556);

        public string Summary { get; set; }
    }
}
