using System;

namespace StrategyPattern
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo) => 
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Rar.");
    }
}
