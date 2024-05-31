namespace att7
{
    internal class Program
    {
        static string[,] delimitar(string s1)
        {
            string[] linhas = s1.Split(";");

            int numeroColunas = linhas[0].Split(',').Length;

            string[,] matriz = new string[linhas.Length, numeroColunas];

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(',');
                for (int j = 0; j < numeroColunas; j++)
                {
                    matriz[i, j] = colunas[j];
                }
            }

            return matriz;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma string contendo dados em formato CSV (valores separados por vírgula) use ; para pular linhas ");
            string CSV = Console.ReadLine();

           string[,] matrix = delimitar(CSV);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
