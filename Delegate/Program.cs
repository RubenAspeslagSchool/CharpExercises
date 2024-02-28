namespace Delegate
{
    internal class Program
    {
        public delegate double ConvertUnit(double value);
        static void Main(string[] args)
        {
            double km = 100;
            ConvertUnit cu;
            cu = new ConvertUnit(KmToMile);
            double mile = cu.Invoke(km);
            Console.WriteLine($"{km} km = {mile} mile");

            double celcius = 10;
            cu = (CelciusToKelvin);
            Console.WriteLine($"{celcius}°c = {cu.Invoke(celcius)}°k");

            cu = delegate (double lbs) { return lbs * 0.456; };


        }

        static double ToCm(double ft, double inch) 
        {
            return ft * 12 * 2 * 45 + inch * 2.54;
        }

        static double KmToMile(double km)
        {
            return km * 1.609;
        }

        static double  CelciusToKelvin(double celcius)
        {
            return celcius * 293.15;
        }
    }
}
