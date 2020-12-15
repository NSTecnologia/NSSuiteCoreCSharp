using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Eventos
{
    public class InutilizarReqNFe : InutilizarReq
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("cUF", Required = Required.Always)]
        public TCodUfIBGE cUF { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("tpAmb", Required = Required.Always)]
        public TAmb tpAmb { get; set; }

        [JsonProperty("nNFIni", Required = Required.Always)]
        public string nNFIni { get; set; }

        [JsonProperty("nNFFim", Required = Required.Always)]
        public string nNFFim { get; set; }

        public override IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/inut";

            Util.GravarLinhaLog("[INUTILIZAR_NUMERACAO_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[INUTILIZAR_NUMERACAO_NFE_INICIO]");

            return JsonConvert.DeserializeObject<InutilizarRespNFe>(resposta);
        }

    }
}
