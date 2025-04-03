namespace MyAgeIn10Years
{
    internal class AgingProgram
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Current Age: " + age);
            Console.WriteLine("Age after 10 years: " + (age + 10));
        }
    }
}