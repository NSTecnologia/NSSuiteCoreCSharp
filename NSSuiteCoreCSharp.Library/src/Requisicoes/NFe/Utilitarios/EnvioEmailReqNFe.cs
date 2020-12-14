using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios
{
    public class EnvioEmailReqNFe : SolicitavelNaAPI, IEnvioEmailReq
    {
        [JsonIgnore()]
        private const string _requestURL = "https://nfe.ns.eti.br/util/resendemail";

        
        [JsonProperty("email", Required = Required.AllowNull)]
        public string[] emails { get; set; }

        [JsonProperty("enviaEmailDoc", Required = Required.AllowNull)]
        public bool? enviaEmailDoc { get; set; }

        [JsonProperty("chNFe", Required = Required.Always)]
        public string chave { get; set; }

        [JsonProperty("anexarPDF", Required = Required.AllowNull)]
        public bool? anexarPDF { get; set; }

        [JsonProperty("anexarEvento", Required = Required.AllowNull)]
        public bool? anexarEvento { get; set; }

        public IResposta Envia()
        {
            Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_INICIO]");
            var resposta = EnviaConteudoParaAPI(this, _requestURL);
            Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_INICIO]");

            return JsonConvert.DeserializeObject<EnvioEmailRespNFe>(resposta);
        }
    }
}
