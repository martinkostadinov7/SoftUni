namespace ComparingNumbersWithoutIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine((a + b + Math.Abs(a - b)) / 2);
        }
    }
}