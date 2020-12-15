using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Requisicoes.NFe;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Eventos
{
    public class DownloadEventoDeDocumento
    {
        [Theory()]
        [MemberData(nameof(GetCancelamentos))]
        public void RealizaUmDownloadDeCancelmanetosESalvaNaMaquina(IDownloadEventoReq downloadEventoReq)
        {
            var downloadEventoResposta = downloadEventoReq.Envia() as IDownloadEventoResp;
            downloadEventoResposta.ValidarESalvar(@"C:\Testes\Eventos\DownloadEventoDFe\", true);
        }

        public static IEnumerable<object[]> GetCancelamentos
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
                        new DownloadEventoReqNFe
                        {
                            
                            chave = "43201207364617000135550000000124861966529827",
                            tpAmb = TAmb.Homologacao,
                            tpDown = Requisicoes._Genericos.Eventos.TipoEvenDownload.XML_E_PDF,
                            tpEvento = TipoDeEventoNFe.CANCELAMENTO,
                            nSeqEvento = 1
                        }
                    },

                };
            }
        }
    }
}
