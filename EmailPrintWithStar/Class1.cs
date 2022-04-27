using System;
using System.Collections.Generic;
using System.Text;

namespace EmailPrintWithStar
{
    internal class Class1
    {
        public static void emailprint()
        {
            Console.WriteLine("Enter your Email:");
            string email= Console.ReadLine();

            string name= email.Substring(0,email.IndexOf("@"));

            //string abc= email.Substring(email.IndexOf("@"),email.Length);

            char[] charArr = name.ToCharArray();

            for (int i = 0; i <charArr.Length; i++)
            {
                if (i<=2)
                    Console.Write(charArr[i]);
                else
                    Console.Write("*");
            }
            Console.WriteLine("@gmail.com");
            Console.ReadLine();
        }
    }
}
