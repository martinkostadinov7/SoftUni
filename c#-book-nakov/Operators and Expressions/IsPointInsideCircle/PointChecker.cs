namespace IsPointInsideCircle
{
    internal class PointChecker
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());

            bool isInside = R * R >= x * x + y * y;
            Console.WriteLine(isInside);
        }
    }
}