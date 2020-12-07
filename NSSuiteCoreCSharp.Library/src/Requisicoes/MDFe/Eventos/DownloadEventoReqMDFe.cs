using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.MDFe
{
    public class DownloadEventoReqMDFe : SolicitavelNaAPI, IDownloadEventoReq
    {
        public string chMDFe { get; set; }
        public int tpAmb { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            throw new System.NotImplementedException();
        }
    }
}