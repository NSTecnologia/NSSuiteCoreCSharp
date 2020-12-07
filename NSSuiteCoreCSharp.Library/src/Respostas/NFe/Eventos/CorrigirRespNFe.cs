using Microsoft.VisualBasic.CompilerServices;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
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

                        Util.GravarLinhaLog("CORRECAO NFE FEITA COM SUCESSO");
                        break;
                    }
                default:
                    throw new RequisicaoCorrecaoException("");
            }
        }
    }
}