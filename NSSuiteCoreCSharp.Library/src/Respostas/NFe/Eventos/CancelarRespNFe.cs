
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Requisicoes.BPe.Eventos;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class CancelarRespNFe : ICancelamentoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoNFe retEvento { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "200":
                    {
                        if (this.retEvento.cStat.Equals("135"))
                            throw new RequisicaoCancelarException("");

                        Util.GravarLinhaLog("CANCELAMENTO NFE REALIZADO COM SUCESSO");
                        break;
                    }
                case "-3":
                    throw new RequisicaoCancelarException("");
                default:
                    throw new RequisicaoCancelarException("");
            }
        }
    }
}