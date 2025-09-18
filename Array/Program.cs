
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("2025106462 - Vinícius Biazzetto");
        Console.WriteLine("2025105504  - Lucas Kauan");
        Console.WriteLine();

        string palavra = RetornarPalavraAleatoria(); 
        char[] exibida = new char[palavra.Length];

        for (int i = 0; i < exibida.Length; i++)
        {
            exibida[i] = '_';
        }

        int tentativas = palavra.Length * 2;
        int usadas = 0;

        Console.WriteLine("Palavra:");
        EscreverPalavra(exibida);
        Console.WriteLine("Tentativas: " + tentativas);

        while (usadas < tentativas && new string(exibida) != palavra)
        {
            Console.Write("\nInforme uma letra: ");
            char letra = Console.ReadLine().ToUpper()[0];
            usadas++;

            RetornarPalavra(palavra, exibida, letra); 
            EscreverPalavra(exibida);
        }

        if (new string(exibida) == palavra)
        {
            Console.WriteLine("\nParabéns, você acertou! Tentativas: " + usadas);
        }
        else
        {
            Console.WriteLine("\nNão foi dessa vez! A palavra era: " + palavra);
        }
    }

        static string RetornarPalavraAleatoria()
    {
        string[] palavras = new string[10];
        palavras[0] = "Abobora";
        palavras[1] = "Banana";
        palavras[2] = "Texto";
        palavras[3] = "Dados";
        palavras[4] = "Linha";
        palavras[5] = "Dardo";
        palavras[6] = "Ler";
        palavras[7] = "Tela";
        palavras[8] = "Teste";
        palavras[9] = "Morder";

        int indice = new Random().Next(0, 10);
        return palavras[indice].ToUpper();
    }

    
    static void RetornarPalavra(string palavra, char[] exibida, char letra)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == letra)
            {
                exibida[i] = letra;
            }
        }
    }

    
    static void EscreverPalavra(char[] exibida)
    {
        for (int i = 0; i < exibida.Length; i++)
        {
            Console.Write(exibida[i] + " ");
        }
        Console.WriteLine();
    }
}
