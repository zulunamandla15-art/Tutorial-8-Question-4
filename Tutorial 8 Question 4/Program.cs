using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tutorial_8_Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Input 20 Characters and count vowels, consonants, special character and digits

            int vowels = 0;
            int consonants = 0;
            int special = 0;
            int digits = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Enter character: ");
                char character = char.Parse(Console.ReadLine());

                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowels++;
                }
                else if (character >= 'a' && character <= 'z')
                {
                    consonants++;
                }
                else if (character == '@' || character == '#' || character == '$' || character == '*')
                {
                    special++;
                }
                else if (character >= '0' && character <= '9')
                {
                    digits++;
                }
            }

            Console.WriteLine("Vowels = " + vowels);
            Console.WriteLine("Consonants = " + consonants);
            Console.WriteLine("Special characters = " + special);
            Console.WriteLine("Digits = " + digits);
        }
    }
}
