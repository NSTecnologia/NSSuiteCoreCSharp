using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class ConsultaCadastroContribuinteRespNFe : IConsultaCadastroContribuinteResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetConsCad retConsCad { get; set; }

        public void Valida()
        {
            if ("200".Equals(this.status))
            {
                if ("111".Equals(retConsCad.infCons.cStat) || "112".Equals(retConsCad.infCons.cStat))
                {
                    Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_FEITO_COM_SUCESSO]");
                    return;
                }
            }
            throw new Exception($"Erro na consulta cadastro contribuinte da NFe: {this.status} - {this.motivo}");
        }
    }
    public class RetConsCad
    {
        public InfCons infCons { get; set; }
        public string versao { get; set; }
    }
    public class InfCons
    {
        public string verAplic { get; set; }
        public int cStat { get; set; }
        public string xMotivo { get; set; }
        public string UF { get; set; }
        public string CNPJ { get; set; }
        public string dhCons { get; set; }
        public int cUF { get; set; }

        protected List<InfCad> infCad { get; set; }
    }
    public class InfCad
    {

        public string IE { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string UF { get; set; }
        public int cSit { get; set; }
        public int indCredNFe { get; set; }
        public int indCredCTe { get; set; }
        public string xNome { get; set; }
        public string xFant { get; set; }
        public string xRegApur{ get; set; }
        public int CNAE { get; set; }
        public string dIniAtiv { get; set; }
        public string dUltSit { get; set; }
        public string dBaixa { get; set; }
        public string IEUnica { get; set; }
        public string IEAtual { get; set; }
        public Ender ender { get; set; }
    }
    public class Ender
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string CEP { get; set; }
    }
}
