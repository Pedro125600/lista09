namespace att6
{
    internal class Program
    {
        public static void ConjugarVerbo(string verbo)
        {
           
             
                string radical = verbo.Substring(0, verbo.Length - 2);
              
            
                Console.WriteLine("Presente do Indicativo:");
                Console.WriteLine($"{radical + "o"}"); 
                Console.WriteLine($"{radical + "as"}"); 
                Console.WriteLine($"{radical + "a"}"); 
                Console.WriteLine($"{radical + "amos"}"); 
                Console.WriteLine($"{radical + "ais"}"); 
                Console.WriteLine($"{radical + "am"}");

                Console.WriteLine("\nPretérito Perfeito do Indicativo:");
                Console.WriteLine($"{radical + "ei"}"); 
                Console.WriteLine($"{radical + "aste"}"); 
                Console.WriteLine($"{radical + "ou"}");
                Console.WriteLine($"{radical + "amos"}");
                Console.WriteLine($"{radical + "astes"}"); 
                Console.WriteLine($"{radical + "aram"}");

                Console.WriteLine("\nFuturo do Presente do Indicativo:");
                Console.WriteLine($"{radical + "arei"}"); 
                Console.WriteLine($"{radical + "arás"}"); 
                Console.WriteLine($"{radical + "ará"}"); 
                Console.WriteLine($"{radical + "aremos"}"); 
                Console.WriteLine($"{radical + "areis"}"); 
                Console.WriteLine($"{radical + "arão"}"); 
            }
           
        

        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um verbo termanado em 'ar' ");
            string verbo = Console.ReadLine();
            ConjugarVerbo(verbo);
         
        }
    }
}
