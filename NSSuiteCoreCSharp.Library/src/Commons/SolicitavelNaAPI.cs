using Newtonsoft.Json;
using NSSuiteCSharpLib.Genericos.Exceptions;
using System;
using System.IO;
using System.Net;

namespace NSSuiteCoreCSharp.Commons
{
    public abstract class SolicitavelNaAPI : ISerializableJSON
    {
        private const string Token = "INSIRA_SEU_TOKEN_AQUI";

        //public abstract IResposta Envia();
        public virtual string ToJSONString()
        {
            return JsonConvert.SerializeObject(this);
        }
        protected string EnviaConteudoParaAPI(SolicitavelNaAPI conteudo, string url, Conteudo tpConteudo = Conteudo.JSON)
        {
            string requisicao = string.Empty;
            string retorno = string.Empty;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Method = "POST";
            httpWebRequest.Headers["X-AUTH-TOKEN"] = Token;

            switch (tpConteudo)
            {
                case Conteudo.JSON:
                    {
                        httpWebRequest.ContentType = "application/json;charset=utf-8";
                        requisicao = conteudo.ToJSONString();
                        break;
                    }
                case Conteudo.XML:
                    {
                        httpWebRequest.ContentType = "application/xml;charset=utf-8";
                        requisicao = Util.GerarXMLDocumento(conteudo);
                        break;
                    }
            }


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(requisicao);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    retorno = streamReader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;

                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                        retorno = streamReader.ReadToEnd();

                    switch (Convert.ToInt32(response.StatusCode))
                    {
                        case 401:
                            throw new ErroRequisicaoAPIException("Token não enviado ou inválido");
                        case 403:
                            throw new ErroRequisicaoAPIException("Token sem permissão");
                        case 404:
                            throw new ErroRequisicaoAPIException("Não encontrado, verifique o retorno para mais informações");
                        default:
                            break;
                    }
                }
            }
            return retorno;
        }
    }
    public enum Conteudo { JSON, XML };
}
