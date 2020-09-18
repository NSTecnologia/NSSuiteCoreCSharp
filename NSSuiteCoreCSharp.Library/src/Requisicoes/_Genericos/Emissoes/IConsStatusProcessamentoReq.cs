using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCSharpLib.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;

namespace NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes
{
    public interface IConsStatusProcessamentoReq : IRequisicao
    {
        string CNPJ { get; set; }
        string nsNRec { get; set; }
        int tpAmb { get; set; }

    }
}
