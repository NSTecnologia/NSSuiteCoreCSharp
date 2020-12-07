
using Newtonsoft.Json;
using System; 
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Respostas.NFe;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.NFe
{
    public class CancelarReqNFe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoNFe
    { 

        public string chNFe { get; set; }
        public int tpAmb { get; set; }
        public DateTime dhEvento { get; set; }
        public string nProt { get; set; }
        public string xJust { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.NFeCancelamento);
            return JsonConvert.DeserializeObject<CancelarRespNFe>(resposta);
        }

        public void EnvioSincrono(TipoEvenDownload tpDown, string caminhoSalvar, bool exibirPDF)
        {
            var cancelamentoResposta = this.Envia() as CancelarRespNFe;
            cancelamentoResposta.Valida();

            var downloadRequisicao = new DownloadEventoReqNFe
            {
                tpAmb = this.tpAmb,
                chNFe = this.chNFe,
                tpDown = tpDown,
                tpEvento = TipoDeEventoNFe.CANC,
                nSeqEvento = 1
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadEventoRespNFe;
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF);
        }
    }
}
