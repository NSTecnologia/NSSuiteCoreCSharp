using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using System;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos
{
    public class DownloadInutilizacaoRespNFe : IDownloadInutilizacaoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetInutNFe retInut { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                if ("102".Equals(this.retInut.cStat))
                {
                    Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_FEITA_COM_SUCESSO]");
                    return;
                }
                throw new Exception();
            }
            else if (erro != null)
                throw new Exception($"{this.erro.cStat} - {this.erro.xMotivo}");
            else
                throw new Exception($"Erro ao fazer Download de Inutilizacao de NFe: {this.status} - {this.motivo}");

        }

        public void ValidarESalvar(string caminho)
        {
            this.Valida();

            string filename = retInut.chave + "-inu";
            Util.SalvarXML(this.retInut.xmlInut, caminho, filename);
        }
    }
}
