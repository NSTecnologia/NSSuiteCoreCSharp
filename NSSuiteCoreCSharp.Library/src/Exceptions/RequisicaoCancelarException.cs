using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    internal class RequisicaoCancelarException : ErroRequisicaoAPIException
    {
        public RequisicaoCancelarException(string msg) : base(msg)
        {
        }
    }
}
