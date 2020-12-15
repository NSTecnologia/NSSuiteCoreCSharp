
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using System.Runtime.Serialization;

namespace NSSuiteCSharpLib.Requisicoes.NFe
{
    public class DownloadEventoReqNFe : SolicitavelNaAPI, IDownloadEventoReq
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chave { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpDown", Required = Required.Always)]
        public TipoEvenDownload tpDown { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpEvento", Required = Required.Always)]
        public TipoDeEventoNFe tpEvento { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("nSeqEvento", Required = Required.Always)]
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/get/event";

            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]");

            return JsonConvert.DeserializeObject<DownloadEventoRespNFe>(resposta);
        }
    }
    public enum TipoDeEventoNFe
    {
        [EnumMember(Value = "CANC")]
        CANCELAMENTO,
        [EnumMember(Value = "CCE")]
        CARTA_DE_CORRECAO
    }
}