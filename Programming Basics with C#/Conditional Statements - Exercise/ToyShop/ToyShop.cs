namespace ToyShop
{
//    Цена на екскурзията - реално число в интервала[1.00 … 10000.00]

//2. Брой пъзели - цяло число в интервала[0… 1000]

//3. Брой говорещи кукли - цяло число в интервала[0 … 1000]

//4. Брой плюшени мечета - цяло число в интервала[0 … 1000]

//5. Брой миньони - цяло число в интервала[0 … 1000]

//6. Брой камиончета - цяло число в интервала[0 … 1000
    internal class ToyShop
    {
        static void Main(string[] args)
        {
            decimal puzzlePrice = 2.6m;
            decimal dollPrice = 3.0m;
            decimal bearPrice = 4.1m;
            decimal minionPrice = 8.2m;
            decimal truckPrice = 2.0m;

            decimal tourPrice = decimal.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine()); 
            int dollCount = int.Parse(Console.ReadLine()); 
            int bearCount = int.Parse(Console.ReadLine()); 
            int minionCount = int.Parse(Console.ReadLine()); 
            int truckCount = int.Parse(Console.ReadLine()); 

            int totalToysCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            decimal totalToysPrice = puzzleCount * puzzlePrice + dollPrice * dollCount + bearPrice * bearCount + minionCount * minionPrice + truckPrice * truckCount;
            if (totalToysCount >= 50)
            {
                totalToysPrice -= totalToysPrice * 0.25m;
            }
            totalToysPrice -= totalToysPrice * 0.1m;

            if (tourPrice <= totalToysPrice)
            {
                decimal moneyLeft = totalToysPrice - tourPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                decimal moneyLeft = tourPrice - totalToysPrice; 
                Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
            }
        }
    }
}
