
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes.NFe;
using NSSuiteCSharpLib.Respostas.NFe;
using System;

namespace NSSuiteCSharpLib.Requisicoes._Genericos
{
    public class CorrigirReqNFe : SolicitavelNaAPI, ICorrigirReq, IEventoSincronoNFe
    {
        public string chNFe { get; set; }
        public string xCorrecao { get; set; }
        public int tpAmb { get; set; }
        public string dhEvento { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.NFeCCe);
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
                tpEvento = TipoDeEventoNFe.CCE,
                nSeqEvento = this.nSeqEvento
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadEventoRespNFe;
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF);
        }
    }
}