using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios
{
    public interface IEnvioEmailReq : IRequisicao
    {
        string chave { get; set; }
        bool? anexarPDF { get; set; }
        bool? anexarEvento { get; set; }
    }
}
