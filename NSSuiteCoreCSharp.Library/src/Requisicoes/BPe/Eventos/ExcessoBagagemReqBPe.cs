using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using System;

namespace NSSuiteCoreCSharp.Requisicoes.BPe.Eventos
{
    public class ExcessoBagagemReqBPe : SolicitavelNaAPI, IRequisicao, IEventoSincronoBPe
    {
        public string chBPe { get; set; }
        public string nProt { get; set; }
        public DateTime dhEvento { get; set; }
        public int tpAmb { get; set; }
        public long qBagagem { get; set; }
        public double vTotTrib { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.BPeExcessoBagagem);
            return JsonConvert.DeserializeObject<ExcessoBagagemRespBPe>(resposta);
        }

        public void EnvioSincrono(string caminhoSalvar)
        {
            var excessoBagagemResposta = this.Envia() as ExcessoBagagemRespBPe;
            excessoBagagemResposta.Valida();

            string xml = excessoBagagemResposta.retEvento.xml;
            string nome = $"110117{excessoBagagemResposta.retEvento.chBPe}-procBPe";           
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
