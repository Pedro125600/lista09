using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static string delimitar(string s1 , char d1 , char d2)
        {
            string[] frases;
            string result;

            if (s1.IndexOf(d1) == -1 && s1.IndexOf(d2) == -1)
            {
                result = "";
            }
            else
            {



                frases = s1.Split(d1, d2);

                result = frases[0];



                for (int i = 1; i < frases.Length; i++)
                {
                    if (frases[i].Length > result.Length)
                    {
                        result = frases[i];
                    }
                }

            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma String");
            string s1 = Console.ReadLine();

            Console.WriteLine("De um caracter para ser o primeiro delimitador");
            char d1 = char.Parse(Console.ReadLine());
            Console.WriteLine("De um caracter para ser o segundo delimitador");
            char d2 = char.Parse(Console.ReadLine());

            Console.WriteLine($"A frase Maior delimitada e  {delimitar(s1, d1, d2)} ");

            Console.ReadLine();

        }
    }
}
