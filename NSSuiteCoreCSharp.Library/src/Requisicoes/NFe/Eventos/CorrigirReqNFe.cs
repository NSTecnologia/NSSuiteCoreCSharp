
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes.NFe;
using NSSuiteCSharpLib.Respostas.NFe;
using System;

namespace NSSuiteCSharpLib.Requisicoes._Genericos
{
    public class CorrigirReqNFe : SolicitavelNaAPI, ICorrigirReq, IEventoSincronoReqNFe
    {
        [JsonProperty("chNFe", Required = Required.Always)]
        public string chNFe { get; set; }

        [JsonProperty("xCorrecao", Required = Required.Always)]
        public string xCorrecao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("dhEvento", Required = Required.Always)]
        public string dhEvento { get; set; }

        [JsonProperty("nSeqEvento", Required = Required.Always)]
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/cce";

            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]");

            return JsonConvert.DeserializeObject<CorrigirRespNFe>(resposta);
        }

        public void EnvioSincrono(TipoEvenDownload tpDown, string caminhoSalvar, bool exibirPDF)
        {
            var ccResposta = this.Envia() as CorrigirRespNFe;
            ccResposta.Valida();

            var downloadRequisicao = new DownloadEventoReqNFe
            {
                tpAmb = this.tpAmb,
                chNFe = this.chNFe,
                tpDown = tpDown,
                tpEvento = TipoDeEventoNFe.CARTA_DE_CORRECAO,
                nSeqEvento = this.nSeqEvento
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadEventoRespNFe;
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF);
        }
    }
}