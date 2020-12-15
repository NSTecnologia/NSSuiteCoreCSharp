using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoConsultaSituacaoException : ErroRequisicaoAPIException
    {
        public RequisicaoConsultaSituacaoException(string message) : base(message)
        {
        }
    }
}
