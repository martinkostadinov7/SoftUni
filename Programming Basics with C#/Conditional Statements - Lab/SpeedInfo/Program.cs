﻿namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            if (n < 10) Console.WriteLine("slow");
            else if (n < 50) Console.WriteLine("average");
            else if (n < 150) Console.WriteLine("fast");
            else if (n < 1000) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");
        }
    }
}
