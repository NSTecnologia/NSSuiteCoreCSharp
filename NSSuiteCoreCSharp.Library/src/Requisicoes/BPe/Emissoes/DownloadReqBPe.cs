using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas.BPe;

namespace NSSuiteCoreCSharp.Requisicoes.BPe.Emissoes
{
    public class DownloadReqBPe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chBPe", Required = Required.Always)]
        public string chBPe { get; set; }

        [JsonProperty("tpDown", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[DOWNLOAD BPE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeDownload);
            Util.GravarLinhaLog("[DOWNLOAD BPE FIM]");

            return JsonConvert.DeserializeObject<DownloadRespBPe>(resposta);
        }
    }
}
