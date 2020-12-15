using Newtonsoft.Json;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Respostas.NFe;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.NFe
{
    public class CancelarReqNFe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoReqNFe
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chave { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("dhEvento", Required = Required.Always)]
        public string dhEvento { get; set; }

        [JsonProperty("nProt", Required = Required.Always)]
        public string nProt { get; set; }

        [JsonProperty("xJust", Required = Required.Always)]
        public string xJust { get; set; }

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/cancel";

            Util.GravarLinhaLog("[CANCELAMENTO_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[CANCELAMENTO_NFE_FIM]");

            return JsonConvert.DeserializeObject<CancelarRespNFe>(resposta);
        }

        public void EnvioSincrono(TipoEvenDownload tpDown, string caminhoSalvar, bool exibirPDF)
        {
            Util.GravarLinhaLog("[CANCELAMENTO_SINCRONO_NFE_INICIO]");

            var cancelamentoResposta = this.Envia();
            cancelamentoResposta.Valida();

            var downloadRequisicao = new DownloadEventoReqNFe
            {
                tpAmb = this.tpAmb,
                chave = this.chave,
                tpDown = tpDown,
                tpEvento = TipoDeEventoNFe.CANCELAMENTO,
                nSeqEvento = 1
            };
            var downloadResposta = downloadRequisicao.Envia() as IDownloadEventoResp;
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF);

            Util.GravarLinhaLog("[CANCELAMENTO_SINCRONO_NFE_FIM]");
        }
    }
}
