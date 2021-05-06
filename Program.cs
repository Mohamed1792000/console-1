using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Out.WriteLine("Enter key :");
            string Key = Console.In.ReadLine();
            string[] keystr = Key.Split(',');
            int[] keyint = new int[keystr.Length];
            for (int i = 0; i < keystr.Length; ++i)
                keyint[i] = int.Parse(keystr[i]);



            Console.Out.WriteLine("Enter Messge");
            string Messge = Console.In.ReadLine();
            string[] Messgestr = Messge.Split(',');
            int[] Messgeint = new int[Messgestr.Length];
            for (int i = 0; i < Messgestr.Length; ++i)
                Messgeint[i] = int.Parse(Messgestr[i]);
            {

                int x[1000];
                for (int i = 0; i < Messge.Length; i++)
                {
                    if (Messgeint + keyint <= 10) ;
                    x = Messgeint + keyint - 10;
                    x = Messgeint + keyint;
                }



            }

        }
       


    }
}
