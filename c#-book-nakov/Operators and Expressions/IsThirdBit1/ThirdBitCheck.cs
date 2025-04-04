using System;

namespace IsThirdBit1
{
    internal class ThirdBitCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool bit3 = (n & 8) != 0;
            Console.WriteLine(bit3);
        }
    }
}