using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void VogaisCosoantes(out int V ,out int C,string s1 )
        {
            V = 0;
            C = 0;

            int[] nun1 = new int[s1.Length];
            char[] v1 = new char[s1.Length];
         


            for (int i = 0; i < v1.Length; i++)
            {
               s1 = s1.ToLower();

                nun1[i] = s1[i];
                v1[i] = s1[i];



                if (nun1[i] > 97 && nun1[i] < 122 )
                {

                    if(v1[i] == 'a' || v1[i] == 'e' || v1[i] == 'i' || v1[i] == 'o' || v1[i] == 'u' )
                    {
                        V++;
                    }
                    else
                    {
                        C++;
                    }

                }
            }

        

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma String");
            string s1 = Console.ReadLine();

            int v  = 0 , C = 0;
            VogaisCosoantes( out v,out  C, s1);

            Console.WriteLine($"A string possui {v} Vogais");
            Console.WriteLine($"A string possui {C} Consoantes");

            Console.ReadLine();
        }
    }
}
