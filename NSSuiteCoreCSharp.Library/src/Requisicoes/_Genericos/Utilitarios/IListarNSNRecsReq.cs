using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genéricas.Utilitarios
{
    public interface IListarNSNRecsReq : IRequisicao
    {
        string chave { get; set; }
    }
}
