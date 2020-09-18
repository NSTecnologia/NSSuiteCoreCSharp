
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.CTe
{
    public class DownloadEventoReqCTe : SolicitavelNaAPI, IDownloadEventoReq
    {
        public string chCTe { get; set; }
        public int tpAmb { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            throw new System.NotImplementedException();
        }

    }
}