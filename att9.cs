namespace att9
{
    internal class Program
    {
        static string ProcessarURL(string url)
        {
            string urlSemEspacos = url.Replace(" ", "%20");

            string urlMinúscula = urlSemEspacos.ToLower();

            return urlMinúscula;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma URL: ");
            string url = Console.ReadLine();

            string urlProcessada = ProcessarURL(url);

            Console.WriteLine("URL processada: " + urlProcessada);

            Console.ReadLine();
        }
    }
}