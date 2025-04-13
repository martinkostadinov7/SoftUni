namespace VirtualTableNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 213;
            decimal b = 21.9121m;
            decimal c = -9.021921029m;

            Console.WriteLine("|{0,-10:X}|{1,-10:F2}|{2,-10:F2}|", a, b, c);
        }
    }
}