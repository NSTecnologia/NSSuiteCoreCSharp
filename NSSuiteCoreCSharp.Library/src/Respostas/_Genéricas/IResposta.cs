using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas._Genéricas
{
    public interface IResposta
    {
        string status { get; set; }
        string motivo { get; set; }
        void Valida();
    }
}
