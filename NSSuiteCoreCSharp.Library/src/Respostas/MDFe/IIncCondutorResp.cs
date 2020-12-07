using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas._Genéricas
{
    public class IncCondutorResp : IResposta
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEvento retEvento { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public void Valida()
        {
            throw new System.NotImplementedException();
        }
    }
}