namespace att8
{
    internal class Program
    {
        static bool polindromo(string s1)
        {
            char[] v1 = s1.ToCharArray();

            for (int i = 0, j = s1.Length - 1; i < j; i++, j--)
            {
                if (v1[i] != v1[j])
                {
                    return false;
                }
            }

            return true;
        }

        static bool[] VerificarPalindromos(string frase)
        {
            string[] palavras = frase.Split(' ');

            bool[] resultados = new bool[palavras.Length];

            for (int i = 0; i < palavras.Length; i++)
            {
                resultados[i] = polindromo(palavras[i]);
            }

            return resultados;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase contendo várias palavras separadas por espaço: ");
            string frase = Console.ReadLine();

            bool[] resultados = VerificarPalindromos(frase);

            for (int i = 0; i < resultados.Length; i++)
            {
                Console.WriteLine($"A palavra '{frase.Split(' ')[i]}' é palíndromo: {resultados[i]}");
            }

            Console.ReadLine();
        }
    }
}
