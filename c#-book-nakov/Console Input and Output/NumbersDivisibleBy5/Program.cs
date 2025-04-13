namespace NumbersDivisibleBy5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int nums = 0;
            nums = (a % 5 == 0) || (b % 5 == 0) ? nums + 1 : nums += 0;
            nums += (b - a) / 5;
            Console.WriteLine(nums);
        }
    }
}
