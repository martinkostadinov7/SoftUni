namespace IsNumPrime
{
    internal class PrimeChecker
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;

            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                isPrime = (n % i == 0) ? false : true;
            }

            Console.WriteLine(isPrime);
        }
    }
}