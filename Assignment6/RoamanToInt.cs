using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class RoamanToInt
    {
        public int RomanValue(char c)
        {
            if (c == 'I')
                return 1;
            if (c=='V')
                return 5;
            if (c == 'x')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;

            return -1;




        }

        public int Romaintonint(string RomanNum)
        {
            int TotalVaue = 0;

            for (int i = 0; i < RomanNum.Length; i++)
            {
                int s1 = RomanValue(RomanNum[i]);

                if (i + 1 < RomanNum.Length)
                {

                    int s2 = RomanValue(RomanNum[i + 1]);


                    if (s1 > s2)
                    {
                        TotalVaue = TotalVaue + s1;

                    }
                    else
                    {

                        TotalVaue = TotalVaue + s2 - s1;
                        i++;
                    }
  }
                else
                {

                    TotalVaue = TotalVaue + s1;
                    i++;
                }

            }
            return TotalVaue;



        }

        public void main()
        {

            string c = "MCMIV";

            Console.WriteLine(Romaintonint(c));


        }


    }
}
