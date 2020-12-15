using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes._Genericos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Eventos
{
    public class CorrigirDocumentoSincrono
    {
        [Theory]
        [MemberData(nameof(GetDFes))]
        public void RealizaUmaEmissaoSincronaDadoUmDFe(IEventoSincronoReqNFe dfe)
        {
            try
            {
                dfe.EnvioSincrono(TipoEvenDownload.XML_E_PDF, @"C:\NotasTeste\", true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static IEnumerable<object[]> GetDFes
        {
            get
            {
                return new[]
                { 
                    //BPe
                    //new object[]
                    //{},

                    //CTe
                    //new object[]
                    //{},

                    //NFe
                    new object[]
                    {
                        new CorrigirReqNFe
                        {  
                            chave = "",
                            tpAmb = TAmb.Homologacao,
                            dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                            nSeqEvento = 1,
                            xCorrecao = "CC-e realizada para teste de integração"
                        }
                    },



                };
            }
        }
    }
}
