using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using static NSSuiteCoreCSharp.Commons.SolicitavelNaAPI;

namespace NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes
{
    public interface IDownloadReq : IRequisicao
    {
        TipoDownloadDFes tpDown { get; set; }
        int tpAmb { get; set; }
    }
}
