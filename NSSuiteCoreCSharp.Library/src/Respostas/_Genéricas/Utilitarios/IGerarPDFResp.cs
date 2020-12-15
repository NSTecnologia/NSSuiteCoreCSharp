using NSSuiteCoreCSharp.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios
{
    public interface IGerarPDFResp : IResposta
    {
        string pdf { get; set; }
        List<string> erros { get; set; }
        Erro erro { get; set; }

        void ValidarESalvar(string caminho, string chaveDeAcesso, bool exibirPDFNaTela);
    }
}
