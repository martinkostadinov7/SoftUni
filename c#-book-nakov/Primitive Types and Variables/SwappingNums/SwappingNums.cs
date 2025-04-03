namespace SwappingNums
{
    internal class SwappingNums
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Swapping two numbers without using a third variable
            int x = 123;
            int y = 999;
            x = y ^ x;
            y = x ^ y;
            x = y ^ x;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
