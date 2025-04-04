namespace DivisionFiveSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool divisionFiveSeven = n % 5 == 0 && n % 7 == 0;
            Console.WriteLine(divisionFiveSeven);
        }
    }
}