using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes.NFe;
using System;
using System.Collections.Generic;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Eventos
{
    public class CancelarDocumentoSincrono
    {

        [Theory]
        [MemberData(nameof(GetDFes))]
        public void RealizaUmaEmissaoSincronaDadoUmDFe(IEventoSincronoReqNFe dfe, TipoEvenDownload tpDown, string caminho, bool exibirPDFNaTela)
        {
            try
            {
                dfe.EnvioSincrono(tpDown, caminho, exibirPDFNaTela);
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
                    //NFe
                    new object[]
                    {
                        new CancelarReqNFe
                        {
                            chave = "43201207364617000135550000000124861966529827",
                            nProt = "143200001088203",
                            tpAmb = TAmb.Homologacao,
                            xJust = "TESTE INTEGRACAO",
                            dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")
                        },
                        TipoEvenDownload.XML_E_PDF,
                        @"C:\Testes\Cancelamentos\NFe\",
                        true
                    },
                };
            }
        }
    }
}
