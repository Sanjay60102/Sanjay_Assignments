using TemperatureConvertor;
namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            Console.WriteLine("Celsius to Fahrenheit: "+temp.CTF(26));
            Console.WriteLine("Fahrenheit to Celsius: "+temp.FTF(87));
        }
    }
}
