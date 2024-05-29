using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attt5
{
    class Program
    {
        static bool polindromo(string s1)
        {
            char[] v1 = s1.ToCharArray();

            for(int i = 0 , j = s1.Length-1; i < s1.Length; i++ , j--)
            {
                if(v1[i] != v1[j])
                {
                    return false;
                }

            }

            return true;
        }





        static void Main(string[] args)
        {

            Console.WriteLine("Escreva uma String");
            string s1 = Console.ReadLine();

            Console.WriteLine($"A string e um palíndromo ? {polindromo(s1)}");
            Console.ReadLine();


        }
    }
}
