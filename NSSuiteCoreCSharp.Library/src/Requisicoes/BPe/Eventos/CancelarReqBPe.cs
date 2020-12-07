using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCSharpLib.Respostas.BPe;
using System;

namespace NSSuiteCSharpLib.Requisicoes.BPe.Eventos
{
    public class CancelarReqBPe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoBPe
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
            cancelamentoResposta.Valida();

            string xml = cancelamentoResposta.retEvento.xml;
            string nome = $"11011{cancelamentoResposta.retEvento.chBPe}1-procNFe";
            try
            {
                Util.SalvarXML(xml, caminhoSalvar, nome);
            }
            catch (Exception e)
            {
                throw new SalvarDocumentosException(e.Message);
            }
        }
    }
}