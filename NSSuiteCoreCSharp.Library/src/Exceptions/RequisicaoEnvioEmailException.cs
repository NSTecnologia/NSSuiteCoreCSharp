using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoEnvioEmailException : ErroRequisicaoAPIException
    {
        public RequisicaoEnvioEmailException(string message) : base(message)
        {
        }
    }
}
