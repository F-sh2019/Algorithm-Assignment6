using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class LongestDistinctSubstring
    {
        public int FindLongestDictinctSubstr(string str)
        {
            Dictionary<char, int> MyDic = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (MyDic.ContainsKey(c))
                {
                    MyDic[c] = MyDic[c] + 1;
                }
                else
                {
                    MyDic.Add(c, 1);
                }


               
            }
            return MyDic.Count;
        }


        public void main()
        {
            string str = "abcdaa";
            Console.WriteLine("The Longest distinct substr is " + FindLongestDictinctSubstr(str));
        
        }

    }
}
