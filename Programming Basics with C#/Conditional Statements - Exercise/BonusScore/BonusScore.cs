﻿namespace BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number <= 1000) 
            {
                bonus = number * 0.2;
            }
            else
            {
                bonus = number * 0.1;
            }

            if (number % 2 == 0) bonus++;
            else if (number % 5 == 0) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + number);
        }
    }
}
