using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter your string: ");
            input = Console.ReadLine();

            Console.WriteLine("Your string: " + input);
            WordCounter(input);
            VowelCounter(input);
            MyClass.IsPalindrome(input);

        }
        static void WordCounter(string userinput)
        {
            int wordcount = userinput.Split().Length;
            // turns the string into substrings on an array as elements
            // and counts the # of elements in the array (word count)


            Console.WriteLine("Word Count: " + wordcount);

        }
        private static void VowelCounter(string userinput2)
        {
            // have to check each spot, or letter, in the string

            int vowelcount = 0;
            for (int i = 0; i < userinput2.Length; i++) // keeps going until it reaches end of string
            {
                if (userinput2[i] == 'a' || userinput2[i] == 'A'
                || userinput2[i] == 'e' || userinput2[i] == 'E'
                || userinput2[i] == 'i' || userinput2[i] == 'I'
                || userinput2[i] == 'o' || userinput2[i] == 'O'
                || userinput2[i] == 'u' || userinput2[i] == 'U')
                {
                    vowelcount++;
                }
            }
            Console.WriteLine("Vowel Count: " + vowelcount);
        }
    }
}
