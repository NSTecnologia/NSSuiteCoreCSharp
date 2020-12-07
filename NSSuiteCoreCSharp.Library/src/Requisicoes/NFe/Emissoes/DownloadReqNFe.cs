
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas.NFe;

namespace NSSuiteCSharpLib.Requisicoes.NFe.Emissoes
{
    public class DownloadReqNFe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chNFe { get; set; }

        [JsonProperty("printCEAN", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool printCEAN { get; set; }
        
        [JsonProperty("obsCanhoto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool obsCanhoto { get; set; }

        [JsonProperty("tpDown", Required = Required.Always)]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[DOWNLOAD NFE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.NFeDownload);
            Util.GravarLinhaLog("[DOWNLOAD NFE FIM]");

            return JsonConvert.DeserializeObject<DownloadRespNFe>(resposta);
        }
    }
}