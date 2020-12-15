using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using System.Collections.Generic;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class PreviaRespNFe : IPreviaResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string pdf { get; set; }
        public List<string> erros { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))           
                return;            
            else if (erros != null)
                throw new RequisicaoPreviaException($"NFe invalida de acordo com a validacao contra schema: {this.erros}");
            else            
                throw new RequisicaoPreviaException($"Erro ao inutilizar NFe: {this.status} - {this.motivo}");                    
        }

        public void ValidarEMostrar()
        {
            this.Valida();

            Util.GerarPDFTemporario(this.pdf);
            Util.GravarLinhaLog($"[PREVIA_GERADA_COM_SUCESSO]");
        }
    }
}
