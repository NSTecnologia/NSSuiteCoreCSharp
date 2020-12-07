using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCSharpLib.Genericos.Exceptions;
using System;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.BPe
{
    public class CancelarRespBPe : ICancelamentoResp
    {
        public RetEventoBPe retEvento { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if (this.status.Equals("200"))
            {
                string cStat = this.retEvento.cStat;
                if (!cStat.Equals("135"))
                    throw new RequisicaoCancelarException("");
            } 
            else if (this.status.Equals("-3"))
            {
                throw new RequisicaoCancelarException("Ocorreu um erro ao Cancelar seu DFe, verifique o log para ter mais informações!");
            }
            else
                throw new RequisicaoCancelarException("Ocorreu um erro ao Cancelar seu DFe, verifique o log para ter mais informações!");
        }
    }
}