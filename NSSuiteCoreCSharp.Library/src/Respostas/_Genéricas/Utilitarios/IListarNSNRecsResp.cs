using NSSuiteCoreCSharp.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios
{
    public interface IListarNSNRecsResp : IResposta
    {
        List<NSNRecs> nsNRecs { get; set; }
    }
    public class NSNRecs
    {
        public string nsNRec { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
    }
}
