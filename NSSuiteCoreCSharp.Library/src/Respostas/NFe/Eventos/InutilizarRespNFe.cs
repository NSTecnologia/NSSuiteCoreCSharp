using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos
{
    public class InutilizarRespNFe : IInutilizarResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetInutNFe retornoInutNFe { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }


        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                Util.GravarLinhaLog("[INUTILIZACAO_NUMERACAO_NFE_FEITA_COM_SUCESSO]");
                return;
            }
            else if (erros != null)
                throw new RequisicaoInutilizarNumeracaoException($"Inutilizacao invalida de acordo com a validacao contra schema: {this.erros}");
            else if (erro != null)
                throw new RequisicaoInutilizarNumeracaoException($"{this.erro.cStat} - {this.erro.xMotivo}");
            else         
                throw new RequisicaoInutilizarNumeracaoException($"Erro ao inutilizar NFe: {this.status} - {this.motivo}");
            
        }

        public void ValidarESalvar(string caminhoSalvar)
        {
            this.Valida();

            string filename = retornoInutNFe.chave + "-inu";       
            Util.SalvarXML(this.retornoInutNFe.xmlInut, caminhoSalvar, filename);
        }
    }
}
