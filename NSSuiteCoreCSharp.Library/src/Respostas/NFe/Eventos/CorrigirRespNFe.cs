using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class CorrigirRespNFe : ICorrigirResp
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
                        if (!retEvento.cStat.Equals("135"))
                            throw new RequisicaoCorrecaoException("");

                        Util.GravarLinhaLog("CORRECAO_NFE_FEITA_COM_SUCESSO");
                        break;
                    }
                default:
                    throw new RequisicaoCorrecaoException("");
            }
        }
    }
}