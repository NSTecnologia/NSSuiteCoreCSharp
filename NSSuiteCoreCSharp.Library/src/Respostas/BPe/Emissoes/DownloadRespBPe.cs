
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas._Genéricas;
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

            string nomeArq = $"{chBPe}-procBPe";

            Util.SalvarXML(this.xml, caminho, nomeArq);

            if (!string.IsNullOrEmpty(this.pdf))
            {
                Util.SalvarPDF(this.pdf, caminho, nomeArq);

                if (exibirPDF)
                    Process.Start($"{caminho + nomeArq}.pdf");
            }
        }

    }
}