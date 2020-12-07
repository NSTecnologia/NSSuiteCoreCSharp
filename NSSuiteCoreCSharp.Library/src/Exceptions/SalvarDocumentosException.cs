using NSSuiteCoreCSharp.Library.src.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Exceptions
{
    public class SalvarDocumentosException : Exception
    {
        public SalvarDocumentosException(string message) : base(message)
        {
            Util.GravarLinhaLog("[ERRO AO SALVAR DOCUMENTO(S)]");
            Util.GravarLinhaLog(message);
        }
    }
}
