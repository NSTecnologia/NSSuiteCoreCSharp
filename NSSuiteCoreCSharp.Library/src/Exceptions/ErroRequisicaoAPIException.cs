using NSSuiteCoreCSharp.Library.src.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class ErroRequisicaoAPIException : Exception
    {
        public ErroRequisicaoAPIException(string message) : base(message)
        {
            Util.GravarLinhaLog("[ERRO_REQUISICAO]");
            Util.GravarLinhaLog(message);
        }
    }
}
