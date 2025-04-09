    namespace FoodDelivery
    {
        internal class FoodDelivery
        {
            static void Main(string[] args)
            {
                decimal chickenPrice = 10.35m;
                decimal fishPrice = 12.40m;
                decimal vegetartianPrice = 8.15m;

                int chickenQuantity = int.Parse(Console.ReadLine());
                int fishQuantity = int.Parse(Console.ReadLine());
                int vegetarianQuantity = int.Parse(Console.ReadLine());
        
            
                decimal foodPrice = chickenPrice * chickenQuantity + fishPrice * fishQuantity + vegetartianPrice * vegetarianQuantity;
                decimal desertPrice = foodPrice * 0.2m;
                decimal totalPrice = foodPrice + desertPrice + 2.5m;
                Console.WriteLine(totalPrice);
            }
        }
    }
