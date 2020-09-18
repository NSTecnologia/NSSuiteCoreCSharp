using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Respostas.NFCe;
using System;

namespace NSSuiteCSharpLib.Requisicoes.NFCe
{
    public class CancelarReqNFCe : SolicitavelNaAPI, ICancelamentoReq, IEventoSincronoReqBPe
    {
        public string chNFe { get; set; }
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