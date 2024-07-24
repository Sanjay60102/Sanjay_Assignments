namespace TemperatureConvertor
{
    public class Temperature
    {
        public double CTF(double temperature)
        {
            double Fahrenheit = temperature * (9 / 5) + 32;
            return Fahrenheit;
        }
        public double FTF(double temperature)
        {
            double Celsius = (temperature - 32) * 5 / 9;
            return Celsius;
        }
    }
}
