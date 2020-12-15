using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using NSSuiteCoreCSharp.Respostas._Genéricas;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class EnvioEmailRespNFe : IEnvioEmailResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public Erro erro { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_FEITO_COM_SUCESSO]");
                return;
            }
            else if (erro != null)
                throw new RequisicaoEnvioEmailException($"{this.erro.cStat} - {this.erro.xMotivo}");
            else
                throw new RequisicaoEnvioEmailException($"Erro ao enviar email da NFe: {this.status} - {this.motivo}");
        }
    }
}
