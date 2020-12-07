using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFCe;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using System.Diagnostics;

namespace NSSuiteCSharpLib.Requisicoes.NFCe
{
    public class DownloadReqNFCe : SolicitavelNaAPI, IDownloadReq
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chNFe { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        [JsonProperty("tpDown", Required = Required.Always)]
        public TipoDownloadDFes tpDown { get; set; }

        [JsonProperty("impressao", Required = Required.Always)]
        public Impressao impressao { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[DOWNLOAD NFCE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.NFeDownload);
            Util.GravarLinhaLog("[DOWNLOAD NFCE FIM]");

            return JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
        }
    }
}