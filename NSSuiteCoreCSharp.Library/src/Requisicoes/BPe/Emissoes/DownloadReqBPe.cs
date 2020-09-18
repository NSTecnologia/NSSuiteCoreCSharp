using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas.BPe;

namespace NSSuiteCoreCSharp.Requisicoes.BPe.Emissoes
{
    public class DownloadReqBPe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chBPe")]
        public string chBPe { get; set; }
        [JsonProperty("tpDown")]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonProperty("tpAmb")]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeDownload);
            return JsonConvert.DeserializeObject<DownloadRespBPe>(resposta);
        }
    }
}
