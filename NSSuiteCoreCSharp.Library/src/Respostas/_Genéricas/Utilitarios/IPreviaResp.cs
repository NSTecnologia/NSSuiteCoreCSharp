using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios
{
    public interface IPreviaResp : IResposta
    {
        string pdf { get; set; }
        void ValidarEMostrar();
    }
}
