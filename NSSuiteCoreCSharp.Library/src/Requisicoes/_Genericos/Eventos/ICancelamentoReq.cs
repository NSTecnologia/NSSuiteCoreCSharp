using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface ICancelamentoReq : IRequisicao
    {
        int tpAmb { get; set; }
        DateTime dhEvento { get; set; }
        string nProt { get; set; }
        string xJust { get; set; }
    }
}
