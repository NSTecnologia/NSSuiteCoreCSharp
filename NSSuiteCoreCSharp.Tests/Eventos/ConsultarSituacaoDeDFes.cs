using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Eventos;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos;
using System;
using System.Collections.Generic;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Eventos
{
    public class ConsultarSituacaoDeDFes
    {
        [Theory()]
        [MemberData(nameof(GetReqs))]
        public void RealizaUmaEmissaoSincronaDadoUmDFe(IConsultarSituacaoReq dfe)
        {
            try
            {
                var respostaConsultaSituacao = dfe.Envia();
                respostaConsultaSituacao.Valida();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static IEnumerable<object[]> GetReqs
        {
            get
            {
                return new[]
                { 
                    //BPe
                    //new object[]
                    //{
                    //   new ConsultarSituacaoReqBPe
                    //   {
                    //       chave = "",
                    //       tpAmb = Library.src.Requisicoes.BPe.Emissoes.TAmb.Homologacao,
                    //       licencaCnpj = "",
                    //       versao = "1.00"
                    //   }
                    //},

                    //CTe
                    //new object[]
                    //{},

                    //NFe
                    new object[]
                    {
                        new ConsultarSituacaoReqNFe
                        {
                            chave = "",
                            tpAmb = Library.src.Requisicoes.NFe.Emissoes.TAmb.Homologacao,
                            licencaCnpj = "",
                            versao = "4.00"
                        }
                    },
                };
            }
        }
    }
}
