using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos;
using NSSuiteCSharpLib.Respostas.NFe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
                throw new RequisicaoDownloadEventoException($"Erro não catalogado, verifique o JSON de resposta: {JsonConvert.SerializeObject(this)}");
        }

        public void ValidarESalvar(string caminho, bool exibirPDF)
        {
            this.Valida();

            Util.CriarDiretorio(caminho);
            string filename = retEvento.chNFe + "-procNFeEven";

            List<Task> tarefas = new List<Task>();        
            tarefas.Add(Util.SalvarXML(this.xml, caminho, filename));
            tarefas.Add(Util.SalvarPDF(this.pdf, caminho, filename, exibirPDF));
            Task.WaitAll(tarefas.ToArray());
        }
    }
}
