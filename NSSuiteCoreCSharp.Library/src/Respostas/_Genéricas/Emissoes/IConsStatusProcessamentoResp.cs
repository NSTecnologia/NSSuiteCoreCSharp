using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas._Genéricas
{
    public interface IConsStatusProcessamentoResp : IResposta
    {
        string xMotivo { get; set; }
        string dhRecbto { get; set; }
        Erro erro { get; set; }
        string cStat { get; set; }
        string nProt { get; set; }
        string xml { get; set; }
    }
}