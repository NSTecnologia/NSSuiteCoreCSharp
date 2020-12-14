using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;
using System;
using System.Collections.Generic;
using System.Text;

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
            switch (this.status)
            {
                case "200":
                case "-6":
                    {
                        Util.GravarLinhaLog($"[ENVIO_FEITO_COM_SUCESSO]");
                        break;
                    }
                case "-7":
                        throw new RequisicaoEmissaoException($"{this.motivo}. nsNRec: {this.nsNRec}");
                case "-4":
                case "-2":
                        throw new RequisicaoEmissaoException($"{this.motivo}. erros: {this.erros}");
                case "-999":
                case "-5":
                        throw new RequisicaoEmissaoException($"{this.erro.xMotivo}.");
                default:
                    try
                    {
                        throw new RequisicaoEmissaoException($"{this.motivo}.");
                    }
                    catch (Exception)
                    {

                        throw new RequisicaoEmissaoException($"{this}.");
                    }
            }
        }
    }
}
