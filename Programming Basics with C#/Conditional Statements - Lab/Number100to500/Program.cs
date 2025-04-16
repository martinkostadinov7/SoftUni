namespace Number100to500
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (n > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else { Console.WriteLine("Between 100 and 200"); }
        }
    }
}
