using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.NFe.Emissoes
{
    public class EnvioRespNFe : IEnvioResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public string nsNRec { get; set; }

        public void Valida()
        {
            throw new NotImplementedException();
        }
    }
}
