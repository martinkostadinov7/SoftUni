namespace SuppliesForSchool
{
    internal class SchoolSupplies
    {
        static void Main(string[] args)
        {
            decimal penPrice = 5.80m;
            decimal markerPrice = 7.20m;
            decimal cleaningPrice = 1.20m;

            int penCount = int.Parse(Console.ReadLine());
            int markerCount = int.Parse(Console.ReadLine());
            int cleaningCount = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            decimal totalPrice = penCount * penPrice + markerCount * markerPrice + cleaningCount * cleaningPrice;
            totalPrice = totalPrice - totalPrice * (discount / 100m);
            Console.WriteLine(totalPrice);
        }
    }
}
