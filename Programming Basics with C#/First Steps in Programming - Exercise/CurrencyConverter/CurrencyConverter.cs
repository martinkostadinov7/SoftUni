namespace CurrencyConverter
{
    internal class CurrencyConverter
    {
        static void Main(string[] args)
        {

            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = usd * 1.79549m;
            Console.WriteLine(bgn);
        }
    }
}
