
namespace ComparingRealNumbers
{
    internal class ComparingRealNumbers
    {
        static void Main(string[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1);
            }
            else Console.WriteLine(n2);
        }
    }
}