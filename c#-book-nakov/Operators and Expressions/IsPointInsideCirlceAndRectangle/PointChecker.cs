namespace IsPointInsideCirlceAndRectangle
{
    internal class PointChecker
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            const int r = 5;
            const int x1 = -1;
            const int y1 = -1;
            const int x2 = 5;
            const int y2 = 5;

            bool isInsideBoth = (r * r >= x * x + y * y) && ((x >= x1 && y >= y1) && (x <= x2 && y <= y2));
            Console.WriteLine(isInsideBoth);
        }
    }
}