using System;

namespace StrategyPattern
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo) =>
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Gzip.");
    }
}
