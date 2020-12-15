using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios
{
    public class ConsultaStatusWSSefazReqNFe : SolicitavelNaAPI, IConsultaStatusWSSefazReq
    {
        [JsonIgnore()]
        private const string _requestURL = "https://nfe.ns.eti.br/util/wssefazstatus";


        [JsonProperty("CNPJCont", Required = Required.Always)]
        public string CNPJCont { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("UF", Required = Required.Always)]
        public TUf UF { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("versao", Required = Required.Always)]
        public string versao { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, _requestURL);
            Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_INICIO]");

            return JsonConvert.DeserializeObject<ConsultaStatusWSSefazRespNFe>(resposta);
        }
    }
}
