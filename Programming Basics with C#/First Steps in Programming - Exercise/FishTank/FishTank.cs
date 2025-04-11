namespace FishTank
{
    internal class FishTank
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            decimal percent = decimal.Parse(Console.ReadLine());

            decimal volume = (length * width * height) / 1000m;

            decimal litersRequired = volume * (1 - (percent / 100));
            Console.WriteLine(litersRequired);


        }
    }
}
