using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class IsRotatingcs
    {
        public bool Isrotating(string a, string b )
        {
            if (a.Length != b.Length)
                return false;
            if (a.Length < 2)
                return a.Equals(a);

            string clock_rot="";
            string anticlock_rot="";
            int len = a.Length;

            clock_rot = clock_rot + b.Substring(2)
                + b.Substring(0, 2);

            anticlock_rot = anticlock_rot + b.Substring(len - 2, len - (len - 2)) + b.Substring(0, len - 2);


            return (a.Equals(clock_rot) || a.Equals(anticlock_rot));


        }
        public void main()
        {
            string a = "amazon";
            string b = "onamaz";
            Console.WriteLine(Isrotating(a, b));


        }


    }
}
