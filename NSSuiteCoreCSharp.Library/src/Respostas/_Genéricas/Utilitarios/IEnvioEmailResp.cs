using NSSuiteCoreCSharp.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios
{
    public interface IEnvioEmailResp : IResposta
    {
        Erro erro { get; set; }
    }
}
