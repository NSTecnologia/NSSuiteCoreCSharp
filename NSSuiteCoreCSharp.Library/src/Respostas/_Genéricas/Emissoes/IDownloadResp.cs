using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;

namespace NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes
{
    public interface IDownloadResp : IResposta
    {
        Erro erro { get; set; }
        string xml { get; set; }
        string pdf { get; set; }

        void ValidarESalvar(string caminho, bool exibirPDF);
    }
}