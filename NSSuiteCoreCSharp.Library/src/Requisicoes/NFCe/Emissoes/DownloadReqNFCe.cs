using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas.NFCe;
using System.Diagnostics;

namespace NSSuiteCSharpLib.Requisicoes.NFCe
{
    public class DownloadReqNFCe : SolicitavelNaAPI, IDownloadReq
    {
        public int tpAmb { get; set; }
        public string chNFe { get; set; }
        public Impressao impressao { get; set; }
        public TipoDownloadDFes tpDown { get; set; }

        public IResposta Envia()
        {
            throw new System.NotImplementedException();
        }
    }
}