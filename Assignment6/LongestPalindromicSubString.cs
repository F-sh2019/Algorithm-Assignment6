using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class LongestPalindromicSubString
    {
        public string TheLongestString(string str)
        {

            int n = str.Length;
            bool[,] table = new bool[n, n];
            string longestPal="";
            for (int i = 0; i < n; i++)
            {
                table[i,i] = true;           
            }
            int maxLenght = 1;
            int start = 0;
            for (int i = 0; i < n - 1; ++i)
                if (str[i] == str[i + 1])
                {

                    table[i, i + 1] = true;
                    start = i;
                    maxLenght = 2;
                    longestPal = str.Substring(i, 2);
                }


            for (int k = 3; k <= n; ++k)
                for (int i = 0; i < n - k + 1; ++i)
                {
                    int j = i + k - 1;

                    if (table[i + 1, j - 1] && str[i] == str[j])
                    {
                        table[i, j] = true;
                        if (k > maxLenght) 
                        {
                            start = i;
                            maxLenght = k;
                            longestPal = str.Substring(i, k);
                        }
                    
                    
                    }
                }

            return longestPal;
        }

        public void main()
        {


            string a = "abad";

            Console.WriteLine("The Longest Palindromic is " + TheLongestString(a));
        
        }
    }
}
