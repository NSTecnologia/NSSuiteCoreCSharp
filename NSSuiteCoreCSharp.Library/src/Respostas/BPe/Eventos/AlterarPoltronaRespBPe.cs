using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Respostas.BPe;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public class AlterarPoltronaRespBPe : IEventoSalvoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEventoBPe retEvento { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            string status = this.status;

            if (status.Equals("200"))
            {
                string cStat = this.retEvento.cStat;
                if (!cStat.Equals("135"))          
                    throw new RequisicaoAlterarPoltronaException("");   
            }
            else
                throw new RequisicaoAlterarPoltronaException("");
        }

        public void ValidarESalvar(string caminhoSalvar)
        {
            this.Valida();
            string xml = this.retEvento.xml;
            string chave = this.retEvento.chBPe;
            string nome = $"AlterarPoltrona{chave}";
            Util.SalvarXML(xml, caminhoSalvar, nome);
        }

    }
}
