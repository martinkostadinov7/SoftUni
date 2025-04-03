namespace DifferentInicializations
{
    internal class DifferentInicializations
    {
        static void Main(string[] args)
        {
            int n1 = 0X100;
            Console.WriteLine(n1);

            char a = (char)0X48;
            Console.WriteLine(a);

            bool isMale = true;

            string word1 = "Hello";
            string word2 = "World";
            object word3 = word1 + " " + word2;
            Console.WriteLine(word3);

            string word4 = "Hello";
            string word5 = "World";
            object word6 = word1 + " " + word2;
            string word7 = word3.ToString();
            Console.WriteLine(word7);

            string sentence = "The \"use\" of quotations causes difficulties.";
            string sentence1 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(sentence);
            Console.WriteLine(sentence1);

            string heart = @"
                 o   o           
               o   o   o 
               o       o
                 o   o
                   o";
            Console.WriteLine(heart);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string triangle = @"
      ©
     © ©
    ©   ©
   ©     ©
  ©       ©      
 ©         ©
©©©©©©©©©©©©©";
            Console.WriteLine(triangle);

            string fisrtName = "Martin";
            string lastName = "Kostadinov";
            byte age = 17;
            char gender = 'm';
            int id = 27560001;

            Console.WriteLine(fisrtName + " " + lastName + " " + age + " " + gender + " " + id);

            int num1 = 5;
            int num2 = 10;

            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
    }
}