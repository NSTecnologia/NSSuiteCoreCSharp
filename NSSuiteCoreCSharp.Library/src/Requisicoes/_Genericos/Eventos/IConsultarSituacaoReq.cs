using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos
{
    public interface IConsultarSituacaoReq : IRequisicao
    {
        string licencaCnpj { get; set; }
        string chave { get; set; }
    }
}
