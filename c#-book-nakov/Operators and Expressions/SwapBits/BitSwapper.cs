namespace SwapBits
{
    internal class BitSwapper
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());

            int bitP1 = (n >> p1) & 1; // намиране на бит на позиция p1
            int bitP2 = (n >> p2) & 1;

            n = n & (~(1 << p2)) | (bitP1 << p2); // n & (~(1<<p2)) - изчиства бита на позиция p2, | (bitP1 << p2) - 
            n = n & (~(1 << p1)) | (bitP2 << p1);

            Console.WriteLine(n);
        }
    }
}