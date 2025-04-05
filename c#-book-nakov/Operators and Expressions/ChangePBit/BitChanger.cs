namespace ChangePBit
{
    internal class BitChanger
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int newN = (v == 1) ? n | (1 << p) : n & (~(1 << p));
            Console.WriteLine(newN);

        }
    }
}