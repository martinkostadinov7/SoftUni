﻿namespace PasswordGuess
{
    internal class PasswordGuess
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string input = Console.ReadLine();
            if (input == password) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
