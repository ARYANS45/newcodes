using System;
using System.Collections.Generic;
using System.Text;

namespace newcodes
{
    public class additionofdigit
    {
        public static void adddigit()
        {
            Console.WriteLine("Program For Addition of Digits :");
         
            int sum = 0;
            Console.WriteLine("Enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine("sum = " + sum);

        }

    }
}
