using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class CancelarRespNFe : ICancelamentoResp
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
                        if (!this.retEvento.cStat.Equals("135"))
                            throw new RequisicaoCancelarException($"Codigo erro: {this.erro.cStat}. Motivo do erro: {this.erro.xMotivo}");

                        Util.GravarLinhaLog("[CANCELAMENTO_NFE_REALIZADO_COM_SUCESSO]");
                        break;
                    }
                case "-3":
                    throw new RequisicaoCancelarException($"Codigo erro: {this.erro.cStat}. Motivo do erro: {this.erro.xMotivo}");
                case "-2":
                    throw new RequisicaoCancelarException($"{this.motivo}");
                default:
                    throw new RequisicaoCancelarException($"Erro não catalogado, verifique o JSON de retono: {JsonConvert.SerializeObject(this)}");
            }
        }
    }
}