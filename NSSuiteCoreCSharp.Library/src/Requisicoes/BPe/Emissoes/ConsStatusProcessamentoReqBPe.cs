using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas.BPe.Emissoes;

namespace NSSuiteCSharpLib.Requisicoes.BPe
{
    public class ConsStatusProcessamentoReqBPe : SolicitavelNaAPI, IConsStatusProcessamentoReq
    {
        [JsonProperty("CNPJ")]
        public string CNPJ { get; set; }

        [JsonProperty("nsNRec")]
        public string nsNRec { get; set; }

        [JsonProperty("tpAmb")]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeConsStatusProcessamento);
            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespBPe>(resposta);
        }
    }
}

