using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios
{
    public class ConsultaCadastroContribuinteReqNFe : SolicitavelNaAPI, IConsultaCadastroContribuinteReq
    {
        [JsonIgnore()]
        private const string _requestURL = "https://nfe.ns.eti.br/util/conscad";


        [JsonProperty("CNPJCont", Required = Required.Always)]
        public string CNPJCont { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("UF", Required = Required.Always)]
        public TUf UF { get; set; }

        [JsonProperty("IE", Required = Required.AllowNull)]
        public string IE { get; set; }

        [JsonProperty("CNPJ", Required = Required.AllowNull)]
        public string CNPJ { get; set; }

        [JsonProperty("CPF", Required = Required.AllowNull)] 
        public string CPF { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, _requestURL);
            Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_INICIO]");

            return JsonConvert.DeserializeObject<ConsultaCadastroContribuinteRespNFe>(resposta);
        }
    }
}
