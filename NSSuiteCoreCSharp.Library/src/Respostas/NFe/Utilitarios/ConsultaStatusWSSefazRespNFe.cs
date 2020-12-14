using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class ConsultaStatusWSSefazRespNFe : IConsultaStatusWSSefazResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetStatusServico retStatusServico { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_FEITO_COM_SUCESSO]");
                return;
            }
            throw new Exception($"Erro ao enviar email da NFe: {this.status} - {this.motivo}");
        }
    }
}
