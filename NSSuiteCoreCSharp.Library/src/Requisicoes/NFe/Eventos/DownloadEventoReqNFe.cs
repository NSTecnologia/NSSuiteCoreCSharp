
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.NFe
{
    public class DownloadEventoReqNFe : SolicitavelNaAPI, IDownloadEventoReq
    {
        public string chNFe { get; set; }
        public TipoEvenDownload tpDown { get; set; }
        public TipoDeEventoNFe tpEvento { get; set; }
        public int tpAmb { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.NFeDownloadEvento);
            return JsonConvert.DeserializeObject<DownloadEventoRespNFe>(resposta);
        }
    }
    public enum TipoEvenDownload
    {
        XP, X, P
    }
    public enum TipoDeEventoNFe
    {
        CANC, CCE
    }
}