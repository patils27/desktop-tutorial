public class Solution {
    public bool IsAnagram(string s, string t) {

     var key = GenerateKey(s);
		var key1  = GenerateKey(t);

		if (key1 == null || key == null)
		{ return false; }

		if(key.Equals(key1))
		{ return true; }

		return false;
    }

    private  string GenerateKey(string str)
	{
		char[] charArray = str.ToCharArray();
		Array.Sort(charArray);
		return new string(charArray);
	}
}