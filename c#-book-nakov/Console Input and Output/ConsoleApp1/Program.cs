namespace BiggestNumberOf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int maxN = Math.Max(a, b);
            int maxN1 = Math.Max(maxN, c);
            int maxN2 = Math.Max(maxN1, d);
            int maxN3 = Math.Max(maxN2, e);
            Console.WriteLine(maxN3);
        }
    }
}