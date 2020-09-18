using NSSuiteCoreCSharp.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas._Genéricas
{
    public interface ICorrigirResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

    }
}