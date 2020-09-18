using NSSuiteCoreCSharp.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas._Genéricas.Eventos
{
    public interface ICancelamentoResp : IResposta
    {
        string status { get; set; }
        string motivo { get; set; }
        List<string> erros { get; set; }
        Erro erro { get; set; }
    }
}
