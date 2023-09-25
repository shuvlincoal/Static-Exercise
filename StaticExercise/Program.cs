namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to convert");
            Console.WriteLine("1 for Fahrenheit to Celsisus");
            Console.WriteLine("2 for Celsisus to Fahrenheit");
            string? tmpConvert = Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter Temp:");
            double tmpTemp = 0;
            string? tmpStr = "";
            tmpStr = Console.ReadLine();
            tmpTemp = Convert.ToDouble(tmpStr);

            if (tmpConvert == "1")
            {
                TempConverter.FahrenheitToCelsius(tmpTemp);
            }
            else if (tmpConvert == "2") 
            {
                TempConverter.CelsiusToFahrenheit(tmpTemp);
            }
        }//Main
    }//Program
}//Namespace
