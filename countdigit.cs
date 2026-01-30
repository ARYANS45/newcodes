using System;
using System.Collections.Generic;
using System.Text;

namespace newcodes
{
    public class countdigit
    {
        public static void cntdigit()
        {
            Console.WriteLine("Program for count digits in number");
            int c=0,n=0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                c = c + 1; 
                n = n / 10;
            }
            Console.WriteLine(c);
        }
    }
}
