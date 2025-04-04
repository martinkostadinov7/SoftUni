namespace EvenOrOdd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string evenOrOdd = n % 2 == 0 ? "even" : "odd";
            Console.WriteLine(evenOrOdd);
        }
    }
}