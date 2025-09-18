
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("2025106346 - Anelise Alves");
        Console.WriteLine("2025106462 - Vinícius Biazzetto");
        Console.WriteLine("2025105504  - Lucas Kauan");
        Console.WriteLine();

        
        string palavra = SortearPalavra();
        char[] escondida = new char[palavra.Length];

        for (int i = 0; i < escondida.Length; i++)
        {
            escondida[i] = '_';
        }

        int tentativas = palavra.Length * 2;
        int usadas = 0;

        Console.WriteLine("Palavra: " + string.Join(" ", escondida));
        Console.WriteLine("Tentativas: " + tentativas);

        while (usadas < tentativas && new string(escondida) != palavra)
        {
            Console.Write("\nInforme uma letra: ");
            char letra = Console.ReadLine().ToUpper()[0];

            bool achou = false;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    escondida[i] = letra;
                    achou = true;
                }
            }

            usadas++;
            Console.WriteLine(string.Join(" ", escondida));

            if (!achou)
            {
                Console.WriteLine("Letra não encontrada.");
            }
        }

        if (new string(escondida) == palavra)
        {
            Console.WriteLine("Parabéns, você acertou! Tentativas: " + usadas);
        }
        else
        {
            Console.WriteLine("Não foi dessa vez! A palavra era: " + palavra);
        }
    }

    static string SortearPalavra()
    {
        string[] lista = { "TESTE", "GATO", "CACHORRO", "CARRO", "CASA", "ESCOLA", "AMIGO", "LIVRO", "JOGO", "FUTEBOL" };
        Random r = new Random();
        int indice = r.Next(0, 10);
        return lista[indice];
    }
}
