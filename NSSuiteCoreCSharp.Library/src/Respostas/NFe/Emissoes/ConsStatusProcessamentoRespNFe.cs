using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.NFe.Emissoes
{
    public class ConsStatusProcessamentoRespNFe : IConsStatusProcessamentoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public string dhRecbto { get; set; }
        public Erro erro { get; set; }
        public string cStat { get; set; }
        public string nProt { get; set; }
        public string xml { get; set; }
        public string chNFe { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "200":
                    {
                        if (!this.cStat.Equals("100"))
                            throw new RequisicaoConsultaEmissaoException($"{this.xMotivo}. cStat: {this.cStat}");

                        Util.GravarLinhaLog($"[CONSULTA_STATUS_PROCESSAMENTO_SUCESSO]");
                        break;
                    }
                case "-2":
                    {
                        if (this.cStat.Equals("996"))
                        {
                            Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NFE_NOVAMENTE...]");
                            throw new InvalidOperationException();
                        }
                        else
                            throw new RequisicaoConsultaEmissaoException($"{this.erro.xMotivo}. cStat: {this.erro.cStat}");
                    }
                default:
                    throw new RequisicaoConsultaEmissaoException($"{this.motivo}.");
            }
        }
    }
}
