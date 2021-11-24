using System;

namespace StrategyPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var context = new CompressaoContext(new CompressaoRar());

            Console.Write("Digite nome do arquivo a comprimir: ");
            var nomeArquivo = Console.ReadLine();

            Console.WriteLine("\nInforme o tipo de compressão a ser usada");
            Console.Write("1- Rar (padrão) \n2- Zip \n3- Gzip \n");
            var opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 2)
                context.DefinirStrategy(new CompressaoZip());
            else if (opcao == 3)
                context.DefinirStrategy(new CompressaoGzip());

            context.CriarArquivoCompactado(nomeArquivo);
        }
    }
}
