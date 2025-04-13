namespace GreaterNumber
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > m) Console.WriteLine(n);
            else Console.WriteLine(m);
        }
    }
}
