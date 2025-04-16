namespace FractionSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double oldSum = 0.0;
            double currentSum = 0.0;
            double precision = 0.001;
            int i = 1;
            while (true)
            {
                currentSum += 1.0 / i;

                if (Math.Abs(currentSum - oldSum) < precision)
                {
                    break;
                }
                oldSum = currentSum;
                i++;
            }
            Console.WriteLine(currentSum);

        }
    }
}