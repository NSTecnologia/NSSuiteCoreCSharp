using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Requisicoes._Genericos.Emissoes;
using NSSuiteCSharpLib.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes.NFe.Emissoes
{
    public class ConsStatusProcessamentoReqNFe : SolicitavelNaAPI, IConsStatusProcessamentoReq
    {
        public string CNPJ { get; set; }
        public string nsNRec { get; set; }
        public int tpAmb { get; set; }

        public IResposta Envia()
        {
            throw new NotImplementedException();
        }
    }
}
