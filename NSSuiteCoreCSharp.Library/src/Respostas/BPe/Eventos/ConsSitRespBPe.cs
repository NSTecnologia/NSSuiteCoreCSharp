using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public class ConsSitRespBPe : IResposta
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetConsSitBPe retConsSitBPe { get; set; }
        public Erro erro { get; set; }
        public void Valida()
        {
            throw new NotImplementedException();
        }
    }
}
