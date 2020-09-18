namespace NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes
{
    public interface IDownloadResp : IResposta
    {
        string status { get; set; }
        string motivo { get; set; }
        Erro erro { get; set; }
        string xml { get; set; }
        string pdf { get; set; }

        void ValidarESalvar(string caminho, bool exibirPDF);
    }
}