namespace BasketballEquipment
{
    internal class BasketEquipment
    {
        static void Main(string[] args)
        {

            int yearTax = int.Parse(Console.ReadLine());
            decimal sneakersPrice = yearTax - yearTax * 0.4m;
            decimal outfitPrice = sneakersPrice - sneakersPrice * 0.2m;
            decimal ballPrice = outfitPrice / 4;
            decimal accesoriesPrice = ballPrice / 5;

            decimal totalSum = yearTax + sneakersPrice + outfitPrice + ballPrice + accesoriesPrice;
            Console.WriteLine(totalSum);
        }
    }
}
