namespace Repainting
{
    internal class Repainting
    {
        static void Main(string[] args)
        {
            decimal naylonPrice = 1.50m;
            decimal paintPrice = 14.50m;
            decimal thinnerPrice = 5m;

            int naylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int thinnerQuantity = int.Parse(Console.ReadLine());
            int hoursWorking = int.Parse(Console.ReadLine());

            naylonQuantity += 2;
            decimal newPaintQuantity = paintQuantity + paintQuantity * 0.1m;

            decimal materialsPrice = 0.40m + (naylonQuantity * naylonPrice + newPaintQuantity * paintPrice + thinnerQuantity * thinnerPrice);
            decimal workersPrice = (materialsPrice * 0.3m) * hoursWorking;

            decimal totalPrice = materialsPrice + workersPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
