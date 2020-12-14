using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes.NFe;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class CancelamentoSincronoDocumento
    {

        [Theory]
        [MemberData(nameof(GetObjects))]
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

        public static IEnumerable<object[]> GetObjects
        {
            get
            {
                return new[]
                { 
                    //NFe
                    new object[]
                    {
                        new CancelarReqNFe
                        {
                            chave = "",
                            nProt = "",
                            tpAmb = TAmb.Homologacao,
                            xJust = "TESTE INTEGRACAO",
                            dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")
                        }
                    },
                    
                    //BPe
                    //new object[]
                    //{}

                };
            }
        }
    }
}
