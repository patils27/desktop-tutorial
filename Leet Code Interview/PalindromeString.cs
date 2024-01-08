using System;

namespace InterviewQuestionsCSharp
{
    public class PalindromeString
    {
        public static void Main(string[] args)
        {
            string inputString = "Rotor";
            string reversedString = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + inputString[i];
            }
            if (inputString.ToLower() == reversedString.ToLower())
            {
                Console.WriteLine("Palindrome String");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}