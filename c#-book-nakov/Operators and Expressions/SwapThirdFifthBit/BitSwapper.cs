using System;

namespace SwapThirdFifthBit
{
    internal class BitSwapper
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int bit2 = (n >> 2) & 1;
            int bit5 = (n >> 5) & 1;

            n = n & (~(1 << 5)) | (bit2 << 5);
            n = n & (~(1 << 2)) | (bit5 << 2);


            Console.WriteLine(n);
        }
    }
}