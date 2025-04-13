namespace CircleCircumfrenceArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the circle is: " + (Math.PI * r * r));
            Console.WriteLine("The circumfrence of the circle is: {0:F2}", (Math.PI * 2 * r));
        }
    }
}