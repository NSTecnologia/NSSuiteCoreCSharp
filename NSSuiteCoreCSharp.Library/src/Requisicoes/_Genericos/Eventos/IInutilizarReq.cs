using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;

namespace NSSuiteCSharpLib.Requisicoes._Genericos.Eventos
{
    public interface IInutilizarReq : IRequisicao
    {
        string cUF { get; set; }
        string ano { get; set; }
        string tpAmb { get; set; }
        string CNPJ { get; set; }
        string serie { get; set; }
        string xJust { get; set; }
    }
}