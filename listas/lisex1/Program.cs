using System;

namespace lisex1;

class Program
{
    public double CelsiusToFahrenheit(double TempCelsius) => TempCelsius * 1.8 + 32;
    public double FahrenheitToCelsius(double TempFahrenheit) => (TempFahrenheit - 32) / 1.8;
    public double CelsiusToKelvin(double TempCelsius) => TempCelsius + 273.15;
    public double KelvinToCelsius(double TempKelvin) => TempKelvin - 273.15;
}
