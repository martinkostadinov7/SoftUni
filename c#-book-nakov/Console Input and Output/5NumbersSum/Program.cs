namespace _5NumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, e;
            bool isA = int.TryParse(Console.ReadLine(), out a);
            bool isB = int.TryParse(Console.ReadLine(), out b);
            bool isC = int.TryParse(Console.ReadLine(), out c);
            bool isD = int.TryParse(Console.ReadLine(), out d);
            bool isE = int.TryParse(Console.ReadLine(), out e);

            int sum = a + b + c + d + e;
            Console.WriteLine(sum);

        }
    }
}