using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class GerarPDFRespNFe : IGerarPDFResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string pdf { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                Util.GravarLinhaLog("[GERAR_PDF_NFE_FEITA_COM_SUCESSO]");
                return;
            }
            else if (erros != null)
                throw new Exception($"Inutilizacao invalida de acordo com a validacao contra schema: {this.erros}");
            else if (erro != null)
                throw new Exception($"{this.erro.cStat} - {this.erro.xMotivo}");
            else
                throw new Exception($"Erro ao gerar pdf de NFe: {this.status} - {this.motivo}");

        }

        public void ValidarESalvar(string caminho, string chaveDeAcesso, bool exibirPDFNaTela)
        {
            this.Valida();

            string filename = $"{chaveDeAcesso}-procNFe";
            var tarefaSalvarPDF = Util.SalvarPDF(this.pdf, caminho, filename, exibirPDFNaTela);
            Task.WaitAll(tarefaSalvarPDF);
        }
    }
}
