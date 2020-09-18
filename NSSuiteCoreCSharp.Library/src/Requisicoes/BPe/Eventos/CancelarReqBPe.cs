using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCSharpLib.Respostas.BPe;
using System;

namespace NSSuiteCSharpLib.Requisicoes.BPe.Eventos
{
    public class CancelarReqBPe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoReqBPe
    {
        public string chBPe { get; set; }
        public int tpAmb { get; set; }
        public DateTime dhEvento { get; set; }
        public string nProt { get; set; }
        public string xJust { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.BPeCancelamento);
            return JsonConvert.DeserializeObject<CancelarRespBPe>(resposta);
        }
        public void EnvioSincrono(string caminhoSalvar)
        {
            var cancelamentoResposta = this.Envia() as CancelarRespBPe;
            cancelamentoResposta.ValidaESalvaXML(caminhoSalvar);
        }
    }
}