using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void PasswordIsCorrect(string password)
        {
            bool lengthAtLeast6 = password.Length >= 6;
            bool containsCapitalLetter = false;
            bool containsSmallLetter = false;
            bool containsNumber = false;
            bool containsSpecialSign = false;
            foreach (char character in password.ToCharArray())
            {
                if (Char.IsUpper(character))
                {
                    containsCapitalLetter = true;
                }
                if (Char.IsLower(character))
                {
                    containsSmallLetter = true;
                }
                if (Char.IsNumber(character))
                {
                    containsNumber = true;
                }
                if (character == '&' || character == '*' || character == '$' || character == '#')
                {
                    containsSpecialSign = true;
                }
            }

            if (lengthAtLeast6 == true && containsCapitalLetter == true && containsSmallLetter == true
                && containsNumber == true && containsSpecialSign)
            {
                Console.WriteLine("Hasło prawidłowe!");
            }
            else
            {
                Console.WriteLine("Hasło nieprawidłowe!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();

            PasswordIsCorrect(password);
        }
    }
}
