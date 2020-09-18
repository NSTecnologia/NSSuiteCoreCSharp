using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;

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