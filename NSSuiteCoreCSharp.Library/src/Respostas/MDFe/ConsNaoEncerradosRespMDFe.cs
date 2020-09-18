﻿using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.MDFe
{
    public class InfMDFe
    {
        public string chMDFe { get; set; }
        public string nProt { get; set; }
    }

    public class RetConsMDFeNaoEnc
    {
        public string tpAmb { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string cUF { get; set; }
        public IList<InfMDFe> infMDFe { get; set; }
    }

    public class ConsNaoEncerradosRespMDFe
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public RetConsMDFeNaoEnc retConsMDFeNaoEnc { get; set; }
    }
}