using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas.NFe;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos
{
    public class DownloadEventoRespNFe : IDownloadEventoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoNFe retEvento { get; set; }
        public string pdf { get; set; }
        public string xml { get; set; }

        public void Valida()
        {
            if (!this.status.Equals("200"))
                throw new RequisicaoDownloadEventoException("");
        }

        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            this.Valida();

            string nome = retEvento.chNFe + "-procNFeEven";

            if (string.IsNullOrEmpty(this.xml))
                Util.SalvarXML(this.xml, caminho, nome);

            if (string.IsNullOrEmpty(this.pdf))
            {
                Util.SalvarPDF(this.pdf, caminho, nome);
                if (exibirPDF)
                    Process.Start(caminho + nome + ".pdf");
            }
        }
    }
}
