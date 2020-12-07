using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Respostas.BPe.Eventos;
using System;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Respostas.BPe.Eventos
{
    public class NaoEmbRespBPe: IResposta, IEventoSalvoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoBPe retEvento { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if (this.status.Equals("200"))
            {
                if (!this.retEvento.cStat.Equals("135"))
                    throw new Exception();
            }
            else
                throw new Exception();
        }
        public void ValidarESalvar(string caminhoSalvar)
        {
            this.Valida();
            string xml = this.retEvento.xml;
            string chave = this.retEvento.chBPe;
            string nome = $"NaoEmbarque{chave}";
            Util.SalvarXML(xml, caminhoSalvar, nome);
        }
    }
}