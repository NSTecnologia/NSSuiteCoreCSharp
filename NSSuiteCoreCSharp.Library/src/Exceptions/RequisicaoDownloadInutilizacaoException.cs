using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoDownloadInutilizacaoException : ErroRequisicaoAPIException
    {
        public RequisicaoDownloadInutilizacaoException(string message) : base(message)
        {
        }
    }
}
