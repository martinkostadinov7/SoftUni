﻿namespace EvenorOdd
{
    internal class EvenorOdd
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
