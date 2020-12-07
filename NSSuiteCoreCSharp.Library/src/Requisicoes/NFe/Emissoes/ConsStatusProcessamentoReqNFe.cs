using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
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

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[CONSULTA PROCESSAMENTO NFE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeConsStatusProcessamento);
            Util.GravarLinhaLog("[CONSULTA PROCESSAMENTO NFE FIM]");

            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNFe>(resposta);
        }
    }
}
