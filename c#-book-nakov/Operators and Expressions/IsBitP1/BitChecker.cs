namespace IsBitP1
{
    internal class BitChecker
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            bool isBit1 = ((v >> p) & 1) != 0;
            Console.WriteLine(isBit1);
        }
    }
}