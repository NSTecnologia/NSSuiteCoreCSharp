using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCSharpLib.Respostas.BPe;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public class ExcessoBagagemRespBPe : IResposta
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoBPe retEvento { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if (this.status.Equals("200"))
            {
                if (!this.retEvento.cStat.Equals("135"))
                {
                      throw new RequisicaoExcessoBagagemException("");  
                }
            } else
            {
                throw new RequisicaoExcessoBagagemException("");
            }
        }
    }
}
