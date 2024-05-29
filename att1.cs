using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static string Iguais(string s1 , string s2)
        {
            string result;

            if(s1 == s2)
            {
                result = "são iguais";
            }

            else
            {
                result = "não são iguais";
            }
            
            return result;
        }

        static bool Suce(string s1 , string s2)
        {

            bool result = false;

            int[] nun1 = new int[s1.Length];
            char[] v1 = new char[s1.Length];
            int[] nun2 = new int[s2.Length];
            char[] v2 = new char[s2.Length];



            for(int i = 0; i < v1.Length ; i++)
            {
                v1[i] = s1[i];
                nun1[i] = v1[i];
            
            }
            for (int i = 0; i < v2.Length; i++)
            {
                v2[i] = s2[i];
                nun2[i] = v2[i];
            }

            for(int i = 0; i < v1.Length && i < v2.Length; i++)
            {
                  if(nun1[i] > nun2[i])
                  {
                    result = true;
                    i = v1.Length + 1;
                  }
                  else
                  {
                    result = false;
                  }
            }

            return result;

        }


        static string Concat(string s1 , string s2)
        {
            string result = s1 + " " + s2;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma String");
            string s1 = Console.ReadLine();

            Console.WriteLine("Escreva outra string");
            string s2 = Console.ReadLine();

            Console.WriteLine($"As strings {Iguais(s1, s2)}");
            Console.WriteLine($"a primeira string suceda a segunda string ? {Suce(s1,s2)}");
            Console.WriteLine($"As strings concatenadas e {Concat(s1 ,s2)}");



            Console.ReadLine();
        }
    }
}
