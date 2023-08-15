using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Strings
    {
        public static void Main(string[] args)
        {
            ///STRINGS
            ///Write a program that counts the number of occurrences of a particular character in a line of text.
            
            String s = Console.ReadLine();

            int count = 0;

            char c= Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < s.Length; i++){
                if (s[i].Equals(c)) 
                {
                    count++;
                }
             }
            Console.WriteLine(count);


            //2Write a program that reads a string and rewrite it in alphabetical order. For example the word STRING should be written as GINRST.

            String s1 = Console.ReadLine();


            char[] c1 = new char[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                c1[i] = s1[i];
            }


            for (int i = 0;i < c1.Length; i++)
            {
                Console.Write(c1[i]);
            }

            foreach (char a in s1)
            {

            }
            Console.ReadKey();

            //3 Write a program in C# Sharp to extract a substring from a given string

             String s3 = Console.ReadLine();

             char[] delimiters = {','};

             String[] s2 = s.Split(delimiters);

             foreach (string item in s2)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine(s2);


            //4 Write a program in C# Sharp to search the position of a substring within a string


            String s4 = Console.ReadLine();

            Console.WriteLine(s.IndexOf((Convert.ToChar(Console.ReadLine()))));


            //5 Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case

            String s5 = Console.ReadLine();
            String s6 = Console.ReadLine();

            Console.WriteLine(s5.Equals(s6));

            Console.WriteLine(s5.ToLower().Equals(s6.ToLower()));
        }
    }
}
