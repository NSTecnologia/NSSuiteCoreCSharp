
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
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