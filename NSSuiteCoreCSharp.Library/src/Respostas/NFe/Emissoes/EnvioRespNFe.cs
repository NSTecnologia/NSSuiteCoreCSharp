using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;
using System;
using System.Collections.Generic;

namespace NSSuiteCoreCSharp.Respostas.NFe.Emissoes
{
    public class EnvioRespNFe : IEnvioResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public string nsNRec { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status) || "-6".Equals(this.status))
            {
                Util.GravarLinhaLog($"[ENVIO_FEITO_COM_SUCESSO]");
                return;
            }                 
            else if ("-7".Equals(this.status))
                throw new RequisicaoEmissaoException($"{this.motivo}. nsNRec: {this.nsNRec}");
            else if (erros != null)
                throw new RequisicaoEmissaoException($"NFe invalida de acordo com a validacao contra schema: {this.erros}");
            else if (erro != null)
                throw new RequisicaoEmissaoException($"{this.erro.cStat} - {this.erro.xMotivo}");
            else
                throw new RequisicaoEmissaoException($"Erro ao Enviar a NFe: {this.status} - {this.motivo}");      
        }
    }
}
