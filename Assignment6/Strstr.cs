using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Strstr
    {
        public int strstr(string s, string x)
        {
           
            if (x == null || x.Length > s.Length || s == null || s.Length == 0)
            {
                return -1;
            }

            bool flag = false;
           

            for (int i = 0; i <= s.Length; i++)
            {
                if (s[i]==x[0])
                  {
                    flag = false;
                    for (int j = 0; j < x.Length; j++)
                    {
                        if (j + i < s.Length)
                        {
                            if (s[i + j] != x[j])
                            {
                                flag = true;
                                break;

                            }
                        
                        }
                    
                    
                    }

                    if (flag==false)
                        return i;


                }

            }

        

            return -1;
        }


        public void main()
        {
            string s = "abacabaaaaaa";
            string x = "abaa";
            Console.WriteLine(strstr(s, x));
        }
    }
}