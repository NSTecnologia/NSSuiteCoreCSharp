using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Requisicoes.BPe.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;

namespace NSSuiteCharpLib.Requisicoes.BPe.Eventos
{
    public class AlterarPoltronaReqBPe : SolicitavelNaAPI, IRequisicao, IEventoSincronoReqBPe
    {
        [JsonProperty("chBPe", Required = Required.Always)]
        public string chBPe { get; set; }

        [JsonProperty("nProt", Required = Required.Always)]
        public string nProt { get; set; }

        [JsonProperty("tpAmb", Required = Required.Always)]
        public int tpAmb { get; set; }

        [JsonProperty("dhEvento", Required = Required.Always)]
        public string dhEvento { get; set; }

        [JsonProperty("poltrona", Required = Required.Always)]
        public int poltrona { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[ALTERAR POLTRONA BPE INICIO]");
            var resposta = EnviaConteudoParaAPI(this, Endpoints.BPeAlteraPoltrona);
            Util.GravarLinhaLog("[ALTERAR POLTRONA BPE FIM]");

            return JsonConvert.DeserializeObject<AlterarPoltronaRespBPe>(resposta);
        }

        public void EnvioSincrono(string caminhoSalvar)
        {
            var alterarPoltronaResposta = this.Envia() as AlterarPoltronaRespBPe;
            alterarPoltronaResposta.ValidarESalvar(caminhoSalvar);
        }
    }
}
