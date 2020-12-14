using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;

namespace NSSuiteCoreCSharp.Respostas._Genéricas.Eventos
{
    public interface IInutilizarResp : IResposta
    {
        void ValidarESalvar(string caminhoSalvar);
    }
}
