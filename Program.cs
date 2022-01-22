using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static string CodeText(string defaultText)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            string codedText = defaultText.ToLower().Replace('a', leetLetters[0]).Replace('e', leetLetters[1])
                .Replace('i', leetLetters[2]).Replace('o', leetLetters[3]).Replace('s', leetLetters[4]);
            return codedText;
        }
        static string UncodeText(string codedText)
        {
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            string uncodedText = codedText.ToLower().Replace('4', naturalLetters[0]).Replace('3', naturalLetters[1])
                .Replace('1', naturalLetters[2]).Replace('0', naturalLetters[3]).Replace('$', naturalLetters[4]); ;
            return uncodedText;
        }

        static void Main(string[] args)
        {
            string defaultText = "Kasia";
            string codedText = CodeText(defaultText);
            Console.WriteLine(codedText);
            string uncodedText = UncodeText(codedText);
            Console.WriteLine(uncodedText);
        }
    }
}
