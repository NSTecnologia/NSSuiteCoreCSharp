
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas._Genéricas;

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
            Util.GravarLinhaLog("[Validando]");
            switch (this.status)
            {
                case "200":
                    {
                        if (this.cStat.Equals("0"))
                        {
                            Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NOVAMENTE...]");
                            this.Valida();
                        }

                        if (!this.cStat.Equals("100"))
                            throw new RequisicaoConsultaEmissaoException($"{this.xMotivo}. " +
                             $"cStat: {this.cStat}");
                        Util.GravarLinhaLog($"[]");
                        break;
                    }
                case "-2":
                    {
                        if (this.cStat.Equals("996"))
                        {
                            Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NOVAMENTE...]");
                            this.Valida();
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