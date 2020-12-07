
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas.CTe;

namespace NSSuiteCSharpLib.Requisicoes.CTe.Emissao
{
    public class DownloadReqCTe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chCTe", Required = Required.Always)]
        public string chCTe { get; set; }

        [JsonProperty("CNPJ", Required = Required.Always)]
        public string CNPJ { get; set; }

        [JsonProperty("tpDown", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[DOWNLOAD CTE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.CTeDownload);
            Util.GravarLinhaLog("[DOWNLOAD CTE INICIO]");

            return JsonConvert.DeserializeObject<DownloadRespCTe>(resposta);
        }
    }
}