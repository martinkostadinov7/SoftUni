using System.Security.Cryptography.X509Certificates;

namespace FourDigitNumber
{
    internal class FourDigitNums
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int d = n % 10;
            n /= 10;
            int c = n % 10;
            n /= 10;
            int b = n % 10;
            n /= 10;
            int a = n % 10;


            int sum = a + b + c + d;
            Console.WriteLine(sum);

            Console.WriteLine($"{d}{c}{b}{a}");

            Console.WriteLine($"{d}{a}{b}{c}");

            Console.WriteLine($"{a}{c}{b}{d}");
        }
    }
}