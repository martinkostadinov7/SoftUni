namespace YardGreening
{
    internal class YardGreening
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double totalCost = area * pricePerSquareMeter;
            double discount = totalCost * 0.18;
            double finalCost = totalCost - discount;
            Console.WriteLine($"The final price is: {finalCost} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
