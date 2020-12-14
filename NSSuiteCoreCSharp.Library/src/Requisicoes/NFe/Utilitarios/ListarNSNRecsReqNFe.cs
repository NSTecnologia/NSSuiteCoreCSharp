using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genéricas.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios
{
    public class ListarNSNRecsReqNFe : SolicitavelNaAPI, IListarNSNRecsReq
    {
        [JsonIgnore()]
        private const string _requestURL = "https://nfe.ns.eti.br/util/list/nsnrecs";

        [JsonProperty("chNFe", Required = Required.Always)]
        public string chave { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[LISTAR_NSNRECS_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, _requestURL);
            Util.GravarLinhaLog("[LISTAR_NSNRECS_NFE_INICIO]");

            return JsonConvert.DeserializeObject<ListarNSNRecsRespNFe>(resposta);
        }
    }
}
