using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoGerarPDFException : ErroRequisicaoAPIException
    {
        public RequisicaoGerarPDFException(string message) : base(message)
        {
        }
    }
}
