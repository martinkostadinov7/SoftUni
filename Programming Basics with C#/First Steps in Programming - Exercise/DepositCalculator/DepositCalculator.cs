namespace DepositCalculator
{
    internal class DepositCalculator
    {
        static void Main(string[] args)
        {
            // сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            /*От конзолата се четат 3 реда:

            1. Депозирана сума – реално число в интервала [100.00 … 10000.00]

            2. Срок на депозита (в месеци) – цяло число в интервала [1…12]

            3. Годишен лихвен процент – реално число в интервала [0.00 …100.00] */

            decimal deposit = decimal.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            decimal interest = decimal.Parse(Console.ReadLine()) / 100;

            decimal sum = deposit + months * ((deposit * interest) / 12);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
