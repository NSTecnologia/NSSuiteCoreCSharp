using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas.NFe.Emissoes;

namespace NSSuiteCoreCSharp.Requisicoes.NFe.Emissoes
{
    public class ConsStatusProcessamentoReqNFe : SolicitavelNaAPI, IConsStatusProcessamentoReq
    {
        [JsonProperty("CNPJ", Required = Required.Always)]
        public string CNPJ { get; set; }

        [JsonProperty("nsNRec", Required = Required.Always)]
        public string nsNRec { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }


        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/issue/status";

            Util.GravarLinhaLog("[CONSULTA_PROCESSAMENTO_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[CONSULTA_PROCESSAMENTO_NFE_FIM]");

            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNFe>(resposta);
        }
    }
}
