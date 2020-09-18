
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;

namespace NSSuiteCSharpLib.Respostas.CTe
{
    public class DownloadRespCTe : IDownloadResp
    {
        public string chCTe { get; set; }
        public string cteProc { get; set; }
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