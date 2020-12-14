using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios
{
    public interface IGerarPDFReq : IRequisicao
    {
        void EnviarSincrono(string caminho, bool exibirNaTela);
    }
}
