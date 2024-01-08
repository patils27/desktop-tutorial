using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class IsomorphicStrings
    {
        public static void Main(string[] args)
        {
            string s = "foo";
            string t = "bar";
            Console.WriteLine(IsIsomorphic(s, t));
        }

        public static bool IsIsomorphic(string s, string t)
        {
            		char[] sTOT = new char[256];
		char[] tTOS = new char[256];

		for (int i = 0;i< s.Length;i++)
		{

			char sChar = s[i];
			char tChar = t[i];

			if (sTOT[sChar] ==0 && tTOS[tChar] == 0)
			{
				sTOT[sChar] = tChar;
				tTOS[tChar] = sChar;
			}else if(sTOT[sChar] != tChar)
			{
				return false;
			}

		}

		return true;
        }
    }
}