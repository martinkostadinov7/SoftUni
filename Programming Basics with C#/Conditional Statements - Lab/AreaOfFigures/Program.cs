namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a * Math.PI;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (a * h) / 2 ;

                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
