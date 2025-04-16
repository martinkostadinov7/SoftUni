namespace First100Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n1 = 0;
            long n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 0; i < 100; i++)
            {
                long next = n1 + n2;
                Console.WriteLine(next);
                n1 = n2;
                n2 = next;

            }
        }
    }
}