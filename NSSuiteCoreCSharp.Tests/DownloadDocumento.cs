using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes.BPe.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class DownloadDocumento
    {

        [Fact]
        public void SucessoDownloadDadoReqDownload()
        {
            var download = new DownloadReqBPe
            {
                chBPe = "43200907364617000135630060000000901490242562",
                tpAmb = 2,
                tpDown = TipoDownloadDFes.XML
            };
            var resposta = download.Envia() as IDownloadResp;
            resposta.ValidarESalvar(@"D:\", true);
        }

    
        [Fact]
        public void ErroDownloadDadoObjetoDFe()
        {
            var download = new DownloadReqBPe
            {
                chBPe = "43200907364617000135630060000000901490242561",
                tpAmb = 2,
                tpDown = TipoDownloadDFes.XML
            };
            var resposta = download.Envia();
            Assert.Throws<RequisicaoDownloadException>(() => resposta.Valida());
        }
    }
}
