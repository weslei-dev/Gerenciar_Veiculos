namespace UploadFile.Models
{
    public class LinhaArquivo
    {
        public LinhaArquivo(string linha, string identificador)
        {
            Linha = linha;
            Identificador = identificador;
        }

        public string Linha { get; set; }
        public string Identificador { get; set; }
    }
}
