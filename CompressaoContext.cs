namespace StrategyPattern
{
    // Context
    public class CompressaoContext
    {
        private ICompressao _compressao;

        public CompressaoContext(ICompressao icompressao)
        {
            _compressao = icompressao;
        }

        public void DefinirStrategy(ICompressao icompressao) => _compressao = icompressao;

        public void CriarArquivoCompactado(string nomeArquivo) => _compressao.ComprimirArquivo(nomeArquivo);
    }
}
