using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class DownloadRespNFe : IDownloadResp
    {
        public string chNFe { get; set; }
        public string nfeProc { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }
        public Erro erro { get; set; }
        public string xml { get; set; }
        public string pdf { get; set; }

        public void Valida()
        {
            throw new System.NotImplementedException();
        }

        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            throw new System.NotImplementedException();
        }
    }
}