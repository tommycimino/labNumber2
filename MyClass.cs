using System;

class MyClass
{

    public static void IsPalindrome(string userInput)
    {
        char[] temp = userInput.ToCharArray(); // places char's of string in an array
        Array.Reverse(temp);                   // reverses the array (backwards string)
        string reverse = new string(temp);

        if (userInput.Equals(reverse)) // sees if the users string is the same if its reversed (palindrome)
        {
            Console.WriteLine("Is Palindrome: Yes");
        }
        else
        {
            Console.WriteLine("Is Palindrome: No");
        }
    }
}