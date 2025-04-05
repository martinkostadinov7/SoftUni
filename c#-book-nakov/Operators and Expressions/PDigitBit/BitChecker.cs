namespace PDigitBit
{
    internal class BitChecker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            bool bit = ((n >> p) & 1) != 0;
            int isBit = bit ? 1 : 0;
            Console.WriteLine(isBit);
        }
    }
}