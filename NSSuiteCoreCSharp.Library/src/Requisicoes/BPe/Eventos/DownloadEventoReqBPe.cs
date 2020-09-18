
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCoreCSharp.src.Commons;
using System.Runtime.Serialization;

namespace NSSuiteCSharpLib.Requisicoes.BPe.Eventos
{
    public class DownloadEventoReqBPe : SolicitavelNaAPI, IDownloadEventoReq
    {
        public string chBPe { get; set; }
        public TipoEventoBPe tpEvento { get; set; }
        public int tpAmb { get; set; }
        public TipoDownloadEventoBPe tpDown { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.BPeDownloadEvento);
            return JsonConvert.DeserializeObject<DownloadEventoRespBPe>(resposta);
        }

    }
    public enum TipoEventoBPe
    {
        [EnumMember(Value = "CANC")]
        CANCELAMENTO,
        [EnumMember(Value = "ALTPOL")]
        ALTERARPOLTRONA,
        //Verificar
        [EnumMember(Value = "11")]
        EXCESSOBAGAGEM,
        [EnumMember(Value = "NAOEMB")]
        NAOEMBARQUE
    }
    public enum TipoDownloadEventoBPe 
    {
        [EnumMember(Value = "X")]
        X,
        [EnumMember(Value = "J")]
        J
    }

}