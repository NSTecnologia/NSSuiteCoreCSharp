using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Eventos
{
    public class DownloadInutilizacaoReqNFe : SolicitavelNaAPI, IDownloadInutilizacaoReq
    {
        [JsonProperty("chave", Required = Required.Always)]
        public string chave { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("tpDown", Required = Required.Always)]
        public string tpDown { get; private set; } = "X";

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/get/inut";

            Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_FIM]");

            return JsonConvert.DeserializeObject<DownloadInutilizacaoRespNFe>(resposta);
        }
    }
}
