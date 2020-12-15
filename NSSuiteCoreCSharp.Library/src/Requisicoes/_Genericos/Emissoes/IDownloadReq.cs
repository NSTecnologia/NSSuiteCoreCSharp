using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes
{
    public interface IDownloadReq : IRequisicao
    {
        TipoDownloadDFes tpDown { get; set; }
    }
}
