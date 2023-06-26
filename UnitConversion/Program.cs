namespace UnitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius to Fahrenheit converter");
            CelsiusToFahrenheitConverter convert2Fahrenheit=new CelsiusToFahrenheitConverter();
            convert2Fahrenheit.TempInCelsius = 25;
            convert2Fahrenheit.Convert();
        }
    }
}