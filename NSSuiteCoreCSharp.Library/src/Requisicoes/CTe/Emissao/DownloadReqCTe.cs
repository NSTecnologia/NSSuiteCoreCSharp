
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;

namespace NSSuiteCSharpLib.Requisicoes.CTe.Emissao
{
    public class DownloadReqCTe : SolicitavelNaAPI, IDownloadReq
    {
        public string chCTe { get; set; }
        public string CNPJ { get; set; }
        public TipoDownloadDFes tpDown { get; set; }
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            throw new System.NotImplementedException();
        }
    }
}