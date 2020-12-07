using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System;

namespace NSSuiteCSharpLib.Respostas.BPe.Emissoes
{
    public class ConsStatusProcessamentoRespBPe : IConsStatusProcessamentoResp
    {
        public string chBPe { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public string dhRecbto { get; set; }
        public Erro erro { get; set; }
        public string cStat { get; set; }
        public string nProt { get; set; }
        public string xml { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "200":
                    {
                        if (this.cStat.Equals("0"))
                        {
                            Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NOVAMENTE...]");
                            throw new InvalidOperationException();
                        }

                        if (!this.cStat.Equals("100"))
                            throw new RequisicaoConsultaEmissaoException($"{this.xMotivo}. " +
                             $"cStat: {this.cStat}");

                        Util.GravarLinhaLog($"[CONSULTA STATUS PROCESSAMENTO SUCESSO]");
                        break;
                    }
                case "-2":
                    {
                        if (this.cStat.Equals("996"))
                        {
                            Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NOVAMENTE...]");
                            throw new InvalidOperationException();
                        }
                        else
                            throw new RequisicaoConsultaEmissaoException(this.erro.xMotivo +
                                ". \ncStat: " + this.erro.cStat);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}