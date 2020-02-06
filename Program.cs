using System;
using System.Collections.Generic;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain;

            do
            {
                Console.Write("Please enter a sentence: ");
                string input = Console.ReadLine().ToLower();
                string[] sentence = input.Split(' ');
                for (int i = 0; i < sentence.Length; i++)
                {
                    Console.Write(Latin(sentence[i]));
                }
                goAgain = GoAgain();
            } while (goAgain == true);
            Console.WriteLine();
            Console.WriteLine("Thank you for playing.");
        }

        static string Latin(string word)
        {
            string vowel = "aeiou";
            string cons = "qwrtypsdfghjklzxcvbnm";
            string translated;
            string translated2;
            if (vowel.Contains(word[0]))
            {
                word = word + "way ";
                return word;
                
            }
            else 
            {
                translated = word;
                for (int i = 0; i < word.Length; i++)
                {
                    
                    translated = (translated.Substring(1) + (word[i]));


                    if (vowel.Contains(translated[0]))
                    {
                        break;
                    }
                }
                translated2 = translated + "ay ";
                return translated2;
            }
        }

        static bool GoAgain ()
        {
            char c;
            bool goAgain;
            do
            {
                Console.WriteLine();
                Console.Write("Would you like to go again? ");
                c = Console.ReadKey().KeyChar;

                if (c == 'n')
                {
                    goAgain = false;
                    return goAgain;
                }
            } while (c != 'y');
            goAgain = true;

            return goAgain;

        }
    }
}
