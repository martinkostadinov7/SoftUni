namespace RectangleAreaPer
{
    internal class RectangleArea
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            double perimeter = 2 * (a + b);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}