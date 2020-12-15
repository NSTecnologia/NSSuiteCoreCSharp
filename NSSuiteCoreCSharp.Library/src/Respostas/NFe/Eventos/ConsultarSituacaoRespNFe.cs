using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos
{
    public class ConsultarSituacaoRespNFe : IConsultarSituacaoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }       
        public RetConsSitNFe retConsSitNFe { get; set; }
        public Erro erro { get; set; }


        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                if ("100".Equals(retConsSitNFe.cStat) ||
                    "101".Equals(retConsSitNFe.cStat) ||
                    "110".Equals(retConsSitNFe.cStat))
                {
                    Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_FEITA_COM_SUCESSO]");
                    return;
                }
            }
            else if(erro != null)
                throw new RequisicaoConsultaSituacaoException($"{this.erro.cStat} - {this.erro.xMotivo}");
            else
                throw new RequisicaoConsultaSituacaoException($"Erro ao Consultar Situacao da NFe: {this.status} - {this.motivo}");
            
        }
    }
    public class RetConsSitNFe
    {
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string nRec { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string cUF { get; set; }
        public string dhRecbto { get; set; }
        public List<TProtNFe> protNFe { get; set; }
        public List<TProcEvento> procEventoNFe { get; set; }
        public string versao { get; set; }
    }
    public class TProtNFe
    {
        public InfProt infProt { get; set; }
        public string versao { get; set; }
    }
    public class InfProt
    {     
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string chNFe { get; set; }
        public string dhRecbto { get; set; }
        public string nProt { get; set; }
        public byte[] digVal { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string Id { get; set; }
    }
    public class TProcEvento
    {
        public TEvento evento { get; set; }
        public TRetEvento retEvento { get; set; }
        public string versao { get; set; }
    }
    public class TEvento
    {
        public TEventoInfEvento infEvento { get; set; }
        public string versao { get; set; }
    }
    public class TEventoInfEvento
    {
        public string cOrgao { get; set; }
        public string tpAmb { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string chNFe { get; set; }
        public string dhEvento { get; set; }
        public string tpEvento { get; set; }
        public string nSeqEvento { get; set; }
        public string verEvento { get; set; }
        public DetEvento detEvento { get; set; }
        public string Id { get; set; }
    }
    public class DetEvento
    {
        public string descEvento{ get; set; }
        public string nProt { get; set; }
        public string xJust { get; set; }
        public string versao { get; set; }

}
    public class TRetEvento
    {
        public TRetEventoInfEvento infEvento { get; set; }
        public String versao { get; set; }
    }
    public class TRetEventoInfEvento
    {
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string cOrgao { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string chNFe { get; set; }
        public string tpEvento { get; set; }
        public string xEvento { get; set; }
        public string nSeqEvento { get; set; }
        public string CNPJDest { get; set; }
        public string CPFDest { get; set; }
        public string emailDest { get; set; }
        public string dhRegEvento { get; set; }
        public string nProt { get; set; }
        public string Id { get; set; }
    }
}
