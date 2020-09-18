using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas.BPe.Eventos;

namespace NSSuiteCSharpLib.Requisicoes.BPe
{
    public class NaoEmbReqBPe : SolicitavelNaAPI, IRequisicao
    {
        public string tpAmb { get; set; }
        public string dhEvento { get; set; }
        public string nProt { get; set; }
        public string xJust { get; set; }
        public string chBPe { get; set; }

        public IResposta Envia()
        {
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeNaoEmb);
            return JsonConvert.DeserializeObject<NaoEmbRespBPe>(resposta);
        }
    }
}