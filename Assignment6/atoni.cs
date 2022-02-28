using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class atoni
    {
        public int atoniV(string s)
        {

            int result = 0;
            int sign = 1;
            int i = 0;
            if (s[0] == '-' )
            {
                sign = -1;
            
            }



            for (; i < s.Length; i++)
            {
                int val = s[i] - '0';
                if (val <= 9 && val >= 0)

                    result = result * 10 + val;

                else
                {
                    result =int.MinValue; 
                }

            
            }

            if (result != int.MinValue)
            {
                result = result * sign;

            
            }


            return result;

        
        }
        public void main()
        {

            string s = "12234";
            Console.WriteLine("The atoni value is" + (atoniV(s)));
            string s1 = "12234s";
            Console.WriteLine("The atoni value is" + (atoniV(s1)));


        }

    }
}
