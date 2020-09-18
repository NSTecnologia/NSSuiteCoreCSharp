using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos;

namespace NSSuiteCharpLib.Requisicoes.BPe.Eventos
{
    public class AlterarPoltronaReqBPe : SolicitavelNaAPI, IRequisicao, IEventoSincronoReqBPe
    {
        public string chBPe { get; set; }
        public string nProt { get; set; }
        public string tpAmb { get; set; }
        public string dhEvento { get; set; }
        public string poltrona { get; set; }

        public IResposta Envia()
        {
            var resposta = EnviaConteudoParaAPI(this, Endpoints.BPeAlteraPoltrona);
            return JsonConvert.DeserializeObject<AlterarPoltronaRespBPe>(resposta);
        }

        public void EnvioSincrono(string caminhoSalvar)
        {
            var alterarPoltronaResposta = this.Envia() as AlterarPoltronaRespBPe;
            alterarPoltronaResposta.ValidaESalvaXML(caminhoSalvar);
        }
    }
}
