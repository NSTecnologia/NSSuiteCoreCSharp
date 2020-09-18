using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.thiss.BPe.Emissoes
{
    public class EnvioRespBPe : IEnvioResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public string nsNRec { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "200":
                case "-6":
                    {
                        break;
                    }
                case "-4":
                case "-2":
                    throw new RequisicaoEmissaoException($"{this.motivo}. \nErros: {this.erros}");
                case "-5":
                    throw new RequisicaoEmissaoException($"{this.erro.xMotivo}. \ncStat: {this.erro.cStat}");
                default:
                    throw new RequisicaoEmissaoException(this.motivo);
            }
        }
    }
}
