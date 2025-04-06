namespace Zooshop
{
    internal class Zooshop
    {
        static void Main(string[] args)
        {
            int catFoodCount = int.Parse(Console.ReadLine());
            int dogFoodCount = int.Parse(Console.ReadLine());
            double catFoodPrice = 4.00;
            double dogFoodPrice = 2.50;
            double totalCost = (catFoodCount * catFoodPrice) + (dogFoodCount * dogFoodPrice);
            Console.WriteLine(totalCost + " lv.");
        }
    }
}
