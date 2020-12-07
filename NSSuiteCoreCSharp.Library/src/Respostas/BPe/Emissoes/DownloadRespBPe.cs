using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genérica;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using System;
using System.Diagnostics;

namespace NSSuiteCSharpLib.Respostas.BPe
{
    public class DownloadRespBPe : IDownloadResp
    {
        public string chBPe { get; set; }
        public NfeProc bpeProc { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }
        public Erro erro { get; set; }
        public string xml { get; set; }
        public string pdf { get; set; }

        public void Valida()
        {
            switch (this.status)
            {
                case "200":
                    {
                        Util.GravarLinhaLog("[DOWNLOAD FEITO COM SUCESSO]");
                        break;
                    }
                case "-2":
                    throw new RequisicaoDownloadException($"{this.motivo}, ele difere de X, P, XP ou PX");
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
                string nomeArq = $"{chBPe}-procBPe";
                if (!string.IsNullOrEmpty(this.xml))
                {
                    Util.SalvarXML(this.xml, caminho, nomeArq);
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