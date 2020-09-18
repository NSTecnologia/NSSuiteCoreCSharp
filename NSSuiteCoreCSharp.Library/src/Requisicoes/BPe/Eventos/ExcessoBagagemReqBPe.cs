using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCoreCSharp.src.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes.BPe.Eventos
{
    public class ExcessoBagagemReqBPe : SolicitavelNaAPI, IRequisicao, IEventoSincronoReqBPe
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
            excessoBagagemResposta.ValidaESalvaXML(caminhoSalvar);
        }
    }
}
