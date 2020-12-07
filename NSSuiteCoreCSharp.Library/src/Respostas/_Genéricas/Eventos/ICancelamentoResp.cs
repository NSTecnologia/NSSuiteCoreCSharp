using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas._Genéricas.Eventos
{
    public interface ICancelamentoResp : IResposta
    {
        List<string> erros { get; set; }
        Erro erro { get; set; }
    }
}
