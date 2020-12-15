
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes.NFe.Emissoes;
using NSSuiteCSharpLib.Respostas.NFe;

namespace NSSuiteCSharpLib.Requisicoes.NFe.Emissoes
{
    public class DownloadReqNFe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chNFe { get; set; }

        [JsonProperty("printCEAN", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? printCEAN { get; set; }
        
        [JsonProperty("obsCanhoto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? obsCanhoto { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpDown", Required = Required.Always)]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/get";

            Util.GravarLinhaLog("[DOWNLOAD_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[DOWNLOAD_NFE_FIM]");

            return JsonConvert.DeserializeObject<DownloadRespNFe>(resposta);
        }
    }
}