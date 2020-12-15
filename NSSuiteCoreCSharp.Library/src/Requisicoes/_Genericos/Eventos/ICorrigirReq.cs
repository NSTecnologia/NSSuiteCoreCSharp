using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface ICorrigirReq : IRequisicao
    {
       string chave { get; set; }
       string dhEvento { get; set; }
       int nSeqEvento { get; set; }
    }
}
