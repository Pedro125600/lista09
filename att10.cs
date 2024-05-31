namespace att10
{
    internal class Program
    {
        static int ContarArquivosComExtensao(string[] arquivos, string sufixo)
        {
            int contador = 0;

            for (int i = 0; i < arquivos.Length; i++)
            {
                string[] partesArquivo = arquivos[i].Split('.');

                if (partesArquivo.Length > 1)
                {
                    string extensao = partesArquivo[partesArquivo.Length - 1];

                    if (extensao == sufixo)
                    {
                        contador++;
                    }
                }

            }
            return contador;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite os arquivos separados por vírgula:");
            string entradaArquivos = Console.ReadLine();
            string[] arquivos = entradaArquivos.Split(',');

            Console.WriteLine("Digite a extensão (sem ponto):");
            string sufixo = Console.ReadLine();
            int quantidade = ContarArquivosComExtensao(arquivos, sufixo);

            Console.WriteLine($"Quantidade de arquivos com a extensão '{sufixo}': {quantidade}");

            Console.ReadLine();
        }
    }
}