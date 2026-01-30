using System;
using System.Collections.Generic;
using System.Text;

namespace newcodes
{
    public class printevno
    {
        public static void evenno()
        { 
            for (int i=0;i<=20;i++)
            {
                if(i % 2==0)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }

    }
}
