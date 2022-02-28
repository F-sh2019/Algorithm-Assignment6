using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class shortenstring
    {

		 public String ShortenString(String str1)
		{

			
			Stack<char> st = new Stack<char>();

			
			int i = 0;

			
			while (i < str1.Length)
			{

				
				if (st.Count == 0 || (st.Count != 0 &&
					str1[i] != st.Peek()))
				{
					st.Push(str1[i]);
					i++;
				}

				
				else
				{
					if (st.Count != 0  && str1[i] == st.Peek())
					{
                        while (i + 1 < str1.Length && str1[i] == str1[i + 1])
							i++;

						st.Pop();
					}
					i++;
				}
			}

			
			if (st.Count == 0)
			{
				return ("Empty String");
			}

			
			else
			{
				String short_String = "";

				while (st.Count != 0)
				{
					short_String = st.Peek() +
								short_String;
					st.Pop();
				}
				return (short_String);
			}
		}



		public string removeadjacent(string s , int startpoint)
		{
			int n = s.Length;
			int i = startpoint;
			int j = i;
			if ( n <= 1 || startpoint == n)
				return s;
			
			if (i + 1 < n && s[i] != s[i + 1])
			{
				while (i < n - 1 && s[i] != s[i + 1])
				{
					if (i < n - 1) i++;
					startpoint++;
				}
				
				//s = removeadjacent(s, i);
				//return s;
			}


			if (i + 1 < n && s[i] == s[i + 1])
			{
				while (i < n - 1  && s[i] == s[i + 1])
				{
					if (i < n-1) i++;
				}

			
			i++;
			s = removeadjacent(s.Substring(0,startpoint )+ s.Substring(i, n - i ), 0);
				
			}
			return s;
			
		}

		public string removeUtil(string str,
						   char last_removed)
		{

			// If length of string is 1 or 0
			if (str.Length == 0 || str.Length == 1)
				return str;

			// Remove leftmost same characters
			// and recur for remaining 
			// string
			if (str[0] == str[1])
			{
				last_removed = str[0];
				while (str.Length > 1 && str[0] ==
					   str[1])
				{
					str = str.Substring(1, str.Length - 1);
				}
				str = str.Substring(1, str.Length - 1);
				return removeUtil(str, last_removed);
			}

			// At this point, the first
			// character is definitely different 
			// from its adjacent. Ignore first
			// character and recursively 
			// remove characters from remaining string
			string rem_str = removeUtil(str.Substring(
			  1, str.Length - 1), last_removed);

			// Check if the first character of
			// the rem_string matches with 
			// the first character of the original string
			if (rem_str.Length != 0 &&
				rem_str[0] == str[0])
			{
				last_removed = str[0];

				// Remove first character
				return rem_str.Substring(1, rem_str.Length - 1);
			}

			// If remaining string becomes
			// empty and last removed character
			// is same as first character of
			// original string. This is needed
			// for a string like "acbbcddc"
			if (rem_str.Length == 0 && last_removed ==
				str[0])
				return rem_str;

			// If the two first characters
			// of str and rem_str don't match, 
			// append first character of str
			// before the first character of
			// rem_str
			return (str[0] + rem_str);
		}

		public  string remove(string str)
		{
			char last_removed = '\0';
			return removeUtil(str, last_removed);
		}

		public  void main()
		{

			string str1 = "SeeTheCode";
			Console.Write(removeadjacent(str1, 0) + "\n");

			string str2 = "azxxxzy";
			Console.Write(removeadjacent(str2, 0) + "\n");

			string str3 = "caaabbbaac";
			Console.Write(removeadjacent(str3, 0) + "\n");

			string str4 = "gghhg";
			Console.Write(removeadjacent(str4, 0) + "\n");

			string str5 = "aaaacddddcappp";
			Console.Write(removeadjacent(str5, 0) + "\n");

			string str6 = "aaaaaaaaaa";
			Console.Write(removeadjacent(str6, 0) + "\n");

			string str7 = "qpaaaaadaaaaadprq";
			Console.Write(removeadjacent(str7, 0) + "\n");

			string str8 = "acaaabbbacdddd";
			Console.Write(removeadjacent(str8, 0) + "\n");

			string str9 = "acbbcdd";
			Console.Write(removeadjacent(str9, 0) + "\n");


			//Console.Write(removeadjacent(str1,0));



			// str1 = "geeksforgeeg";
			//Console.Write(remove(str1) + "\n");

			// str2 = "azxxxzy";
			//Console.Write(remove(str2) + "\n");

			// str3 = "caaabbbaac";
			//Console.Write(remove(str3) + "\n");

			// str4 = "gghhg";
			//Console.Write(remove(str4) + "\n");

			// str5 = "aaaacddddcappp";
			//Console.Write(remove(str5) + "\n");

			// str6 = "aaaaaaaaaa";
			//Console.Write(remove(str6) + "\n");

			// str7 = "qpaaaaadaaaaadprq";
			//Console.Write(remove(str7) + "\n");

			// str8 = "acaaabbbacdddd";
			//Console.Write(remove(str8) + "\n");

			// str9 = "acbbcdd";
			//Console.Write(remove(str9) + "\n");
		}
	}

	
}

