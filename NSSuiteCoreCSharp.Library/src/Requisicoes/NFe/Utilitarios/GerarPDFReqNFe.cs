using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios
{
    public class GerarPDFReqNFe : SolicitavelNaAPI, IGerarPDFReq
    {
        [JsonIgnore()]
        private const string _requestURL = "https://nfe.ns.eti.br/util/generatepdf";

        [JsonProperty("xml", Required = Required.Always)]
        public string NFeXmlProc { get; set; }

        [JsonProperty("printCEAN", Required = Required.AllowNull)]
        public bool? printCEAN { get; set; }

        [JsonProperty("obsCanhoto", Required = Required.AllowNull)]
        public bool? obsCanhoto { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[GERAR_PDF_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, _requestURL);
            Util.GravarLinhaLog("[GERAR_PDF_NFE_FIM]");

            return JsonConvert.DeserializeObject<GerarPDFRespNFe>(resposta);
        }

        public void EnviarSincrono(string caminho, bool exibirNaTela)
        {
            var gerarPDFResp = this.Envia() as GerarPDFRespNFe;
            string chNFe = Util.LerElementoDeXMLString(NFeXmlProc, "chNFe");
            gerarPDFResp.ValidarESalvar(caminho, chNFe, exibirNaTela);
        }
    }
}
