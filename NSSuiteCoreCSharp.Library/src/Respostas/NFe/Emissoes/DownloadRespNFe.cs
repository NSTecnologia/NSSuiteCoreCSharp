using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class DownloadRespNFe : IDownloadResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string chNFe { get; set; }
        public string nfeProc { get; set; }
        public Erro erro { get; set; }
        public string xml { get; set; }
        public string pdf { get; set; }

        public void Valida()
        {
            if (!"200".Equals(this.status))
            {
                throw new RequisicaoDownloadException($"{this.motivo}.");
            }
            Util.GravarLinhaLog($"[DOWNLOAD_NFE_FEITO_COM_SUCESSO]");
        }

        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            this.Valida();

            Util.CriarDiretorio(caminho);
            string filename = $"{this.chNFe}-procNFe";

            Util.GravarLinhaLog("[BAIXANDO_DOCUMENTOS_NA_MAQUINA]");
            Util.GravarLinhaLog($"[CAMINHO_DOCUMENTOS] - {caminho}");
            List<Task> tarefas = new List<Task>();
            tarefas.Add(Util.SalvarXML(this.xml, caminho, filename));
            tarefas.Add(Util.SalvarPDF(this.pdf, caminho, filename, exibirPDF));
            Task.WaitAll(tarefas.ToArray());
        }
    }
}