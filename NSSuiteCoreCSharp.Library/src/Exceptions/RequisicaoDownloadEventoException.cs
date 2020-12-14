using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class RequisicaoDownloadEventoException : ErroRequisicaoAPIException
    {
        public RequisicaoDownloadEventoException(string msg) : base(msg)
        {
        }
    }
}
