namespace VacationBookList
{
    internal class BookList
    {
        static void Main(string[] args)
        {

            int pages = int.Parse(Console.ReadLine());
            int pagesByHour = int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            Console.WriteLine((pages / pagesByHour) / daysToRead);

        }
    }
}
