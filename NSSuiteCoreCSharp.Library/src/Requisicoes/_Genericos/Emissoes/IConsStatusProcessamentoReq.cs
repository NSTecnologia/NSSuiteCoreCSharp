using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Emissoes
{
    public interface IConsStatusProcessamentoReq : IRequisicao
    {
        string CNPJ { get; set; }
        string nsNRec { get; set; }

    }
}
