
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;

namespace NSSuiteCSharpLib.Requisicoes.NFe.Emissoes
{
    public class DownloadReqNFe : SolicitavelNaAPI, IDownloadReq
    {
        public string chNFe { get; set; }
        public bool printCEAN { get; set; }
        public TipoDownloadDFes tpDown { get; set; }
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            throw new System.NotImplementedException();
        }
    }
}