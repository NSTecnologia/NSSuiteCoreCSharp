
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genérica;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System;
using System.Diagnostics;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFCe
{
    public class DownloadRespNFCe : IResposta
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public NfeProc nfeProc { get; set; }
        public string pdf { get; set; }
        public RetEvento retEvento { get; set; }
        public string chNFe { get; set; }
        public string pdfCancelamento { get; set; }
        public string escpos { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "100":
                    Util.GravarLinhaLog("DOWNLOAD NFCE FEITO COM SUCESSO");
                    break;
                case "-100":
                    throw new RequisicaoDownloadException(this.motivo);
                default:
                    throw new RequisicaoDownloadException(this.motivo);
            }
        }

        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            this.Valida();
            Util.GravarLinhaLog($"[SALVANDO DOCUMENTO(S) EM {caminho}]");
            try
            {
                string nomeArq = $"{nfeProc.chNFe}-procNFe";
                if (!string.IsNullOrEmpty(this.nfeProc.xml))
                {
                    Util.SalvarXML(this.nfeProc.xml, caminho, nomeArq);
                }
                if (!string.IsNullOrEmpty(this.pdf))
                {
                    Util.SalvarPDF(this.pdf, caminho, nomeArq);

                    if (exibirPDF)
                        Process.Start(@"cmd.exe ", $"/c {caminho + nomeArq}.pdf");
                }
                Util.GravarLinhaLog("[DOCUMENTO(S) SALVO(S)]");
            }
            catch (Exception e)
            {
                throw new SalvarDocumentosException(e.Message);
            }

        }
    }
}