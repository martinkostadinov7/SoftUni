namespace TimePlusMinutes
{
    internal class TimePlusMinutes
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.Write($"{hours}:");

            if (minutes < 10)
            {
                Console.Write($"0{minutes}");
            }
            else
            {
                Console.Write($"{minutes}");
            }
        }
    }
}
