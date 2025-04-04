namespace MoonGravity
{
    internal class MoonGravityCalculator
    {
        static void Main(string[] args)
        {
            double earthKg = double.Parse(Console.ReadLine());
            double moonKg = earthKg - earthKg * 0.17;
            Console.WriteLine(moonKg);
        }
    }
}