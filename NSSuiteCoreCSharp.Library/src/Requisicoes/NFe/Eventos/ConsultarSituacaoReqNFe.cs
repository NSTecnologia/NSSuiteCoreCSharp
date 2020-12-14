using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Eventos
{
    public class ConsultarSituacaoReqNFe : SolicitavelNaAPI, IConsultarSituacaoReq
    {
        [JsonProperty("licencaCnpj", Required = Required.Always)]
        public string licencaCnpj { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("chNFe", Required = Required.Always)]
        public string chNFe { get; set; }

        [JsonProperty("versao", Required = Required.Always)]
        public string versao { get; set; }

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/stats";

            Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_FIM]");

            return JsonConvert.DeserializeObject<ConsultarSituacaoRespNFe>(resposta);
        }
    }
}
