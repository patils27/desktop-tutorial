using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTestApp
{
	public  class Anagrams
	{
		public static void Main(string[] args)
		{
			string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
			var res = GroupAnagrams(strs);
			Console.WriteLine(res);
		}

		public static List<List<string>> GroupAnagrams(string[] strs)
		{
			Dictionary<string, List<string>> mappedStrs = new Dictionary<string, List<string>>();

			foreach (string s in strs)
			{
				string key = GenerateKey(s);
				if (!mappedStrs.ContainsKey(key))
				{
					mappedStrs.Add(key, new List<string>());
				}
				mappedStrs[key].Add(s);
			}

			return new List<List<string>>(mappedStrs.Values);
		}

		private static string GenerateKey(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Sort(charArray);
			return new string(charArray);
		}

	}
}
