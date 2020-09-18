
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;

namespace NSSuiteCSharpLib.Respostas.MDFe
{
    public class DownloadRespMDFe : IDownloadResp
    {
        public string chMDFe { get; set; }
        public string mdfeProc { get; set; }
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