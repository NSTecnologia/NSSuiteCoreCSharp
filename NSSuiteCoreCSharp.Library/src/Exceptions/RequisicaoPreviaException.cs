using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoPreviaException : ErroRequisicaoAPIException
    {
        public RequisicaoPreviaException(string message) : base(message)
        {
        }
    }
}
