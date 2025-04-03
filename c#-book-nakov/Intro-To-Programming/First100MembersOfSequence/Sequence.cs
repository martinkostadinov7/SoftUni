namespace First100MembersOfSequence
{
    internal class Sequence
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                int num = i + 2;
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine(num * -1);
                }
            }
        }
    }
}