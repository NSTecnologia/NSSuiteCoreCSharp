
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCSharpLib.Requisicoes._Genericos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Respostas.CTe;
using System;

namespace NSSuiteCSharpLib.Requisicoes.CTe
{
    public class CancelarReqCTe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoReqBPe
    {
        public string chCTe { get; set; }
        public int tpAmb { get; set; }
        public DateTime dhEvento { get; set; }
        public string nProt { get; set; }
        public string xJust { get; set; }

        public IResposta Envia()
        {
            throw new NotImplementedException();
        }
        public void EnvioSincrono(string caminhoSalvar)
        {
            throw new NotImplementedException();
        }
    }
}