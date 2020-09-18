using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes
{
    public interface IEmissaoDFeSincrona : IRequisicao
    {
        void EnvioSincrono(TipoDownloadDFes tpDown, string caminho, bool exibirNaTela, bool a3);
    }
    public enum TipoDownloadDFes
    { 
        X, J, P, XP, JP
    }
}
