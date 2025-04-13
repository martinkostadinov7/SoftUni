namespace CompanyInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            int phoneNumber = int.Parse(Console.ReadLine());
            int faxNumber = int.Parse(Console.ReadLine());
            string website = Console.ReadLine();
            string managerName = Console.ReadLine();
            string managerLatName = Console.ReadLine();
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Company info: Name: {name} \nAddress: {address} \nPhone number: {phoneNumber} \nFax: {faxNumber} \nWebsite: {website} \nManaged by {managerName} {managerLatName} with phone number: {managerPhoneNumber}");

        }
    }
}