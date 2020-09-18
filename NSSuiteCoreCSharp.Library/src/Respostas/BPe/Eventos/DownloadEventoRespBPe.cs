using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas.BPe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public class DownloadEventoRespBPe : IDownloadResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoBPe retEvento { get; set; }
        public Erro erro { get; set; }
        public string xml { get; set; }
        public string pdf { get; set; }
        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            if (string.IsNullOrEmpty(this.xml))
                Util.SalvarXML(this.xml, caminho, retEvento.chBPe + "-procEven");

            if (string.IsNullOrEmpty(this.pdf))
            {
                Util.SalvarPDF(this.pdf, caminho, retEvento.chBPe + "-procEven");
                if (exibirPDF)
                    Process.Start(caminho + retEvento.chBPe + ".pdf");
            }
        }

        public void Valida()
        {
            if (!this.status.Equals("200"))
                throw new RequisicaoDownloadEventoException("Ocorreu um erro, veja o retorno da API para mais informações");
        }
    }
}
