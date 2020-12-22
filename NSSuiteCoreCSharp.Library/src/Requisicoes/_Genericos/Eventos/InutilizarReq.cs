using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;

namespace NSSuiteCSharpLib.Requisicoes._Genericos.Eventos
{
    public abstract class InutilizarReq : SolicitavelNaAPI, IRequisicao
    {
        [JsonProperty("ano", Required = Required.Always)]
        public string ano { get; set; }

        [JsonProperty("CNPJ", Required = Required.Always)]
        public string CNPJ { get; set; }

        [JsonProperty("serie", Required = Required.Always)]
        public string serie { get; set; }

        [JsonProperty("xJust", Required = Required.Always)]
        public string xJust { get; set; }

        public abstract IResposta Envia();

        public void EnvioSincrono(string caminhoSalvar)
        {
            var inutilizacaoResp = this.Envia() as IInutilizarResp;
            inutilizacaoResp.ValidarESalvar(caminhoSalvar);
        }
    }
}