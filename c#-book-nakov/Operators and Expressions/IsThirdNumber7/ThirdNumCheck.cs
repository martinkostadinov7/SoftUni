namespace IsThirdNumber7
{
    internal class ThirdNumCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n / 100;
            bool is7 = n1 % 10 == 7;
            Console.WriteLine(is7);
        }
    }
}