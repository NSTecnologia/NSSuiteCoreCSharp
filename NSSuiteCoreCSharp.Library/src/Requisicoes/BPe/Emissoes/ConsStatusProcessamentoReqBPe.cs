using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas.BPe.Emissoes;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Emissoes
{
    public class ConsStatusProcessamentoReqBPe : SolicitavelNaAPI, IConsStatusProcessamentoReq
    {
        [JsonProperty("CNPJ", Required = Required.Always)]
        public string CNPJ { get; set; }

        [JsonProperty("nsNRec", Required = Required.Always)]
        public string nsNRec { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[CONSULTA PROCESSAMENTO BPE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeConsStatusProcessamento);
            Util.GravarLinhaLog("[CONSULTA PROCESSAMENTO BPE FIM]");

            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespBPe>(resposta);
        }
    }
}

