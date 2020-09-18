
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Requisicoes.BPe.Eventos;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.BPe
{
    public class CancelarRespBPe : ICancelamentoResp, IEventoSalvoRespBPe
    {
        public RetEventoBPe retEvento { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if (this.status.Equals("200"))
            {
                string cStat = this.retEvento.cStat;
                if (!cStat.Equals("135"))
                    throw new RequisicaoCancelarException("");
            }
            else
                throw new RequisicaoCancelarException("Ocorreu um erro ao Cancelar seu DFe, verifique o log para ter mais informações!");
        }
        public void ValidaESalvaXML(string caminhoSalvar)
        {
            this.Valida();
            string xml = retEvento.xml;
            string chave = retEvento.chBPe;
            Util.SalvarXML(xml, caminhoSalvar, chave);
        }
    }
}