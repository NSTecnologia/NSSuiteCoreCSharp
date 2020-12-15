using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface ICancelamentoReq : IRequisicao
    {
        string chave { get; set; }
        string dhEvento { get; set; }
        string nProt { get; set; }
        string xJust { get; set; }
    }
}
