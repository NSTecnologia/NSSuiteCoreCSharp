using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas._Genéricas
{
    public interface ICorrigirResp : IResposta
    {
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

    }
}