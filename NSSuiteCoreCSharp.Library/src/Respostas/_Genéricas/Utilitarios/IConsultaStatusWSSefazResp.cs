using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios
{
    public interface IConsultaStatusWSSefazResp : IResposta
    {
        RetStatusServico retStatusServico { get; set; }
    }
    public class RetStatusServico
    {
        public string cStat { get; set; }
        public string xMotivo { get; set; }
    }
}
