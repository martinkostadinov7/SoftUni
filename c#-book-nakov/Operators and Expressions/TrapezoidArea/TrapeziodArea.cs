namespace TrapezoidArea
{
    internal class TrapeziodArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(((a + b) / 2) * h);
        }
    }
}