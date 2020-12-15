using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    internal class RequisicaoAlterarPoltronaException : ErroRequisicaoAPIException
    {
        public RequisicaoAlterarPoltronaException(string msg) : base(msg)
        {
        }
    }
}
