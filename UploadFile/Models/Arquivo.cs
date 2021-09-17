namespace UploadFile.Models
{
    public class Arquivo
    {
        public Arquivo(string conteudo)
        {
            Conteudo = conteudo;
        }

        public string Conteudo { get; set; }
    }
}
