using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Eventos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Eventos
{
    public class InutilizacaoDocumento
    {
        [Fact()]
        public void RealizaUmaInutilizacaoSincronaDadoUmNFe()
        {
            InutilizarReq inutilizacao = new InutilizarReqNFe
            {
                cUF =  Library.src.Requisicoes.NFe.Emissoes.TCodUfIBGE.RS,
                tpAmb = Library.src.Requisicoes.NFe.Emissoes.TAmb.Homologacao,
                ano = "20",
                CNPJ = "07364617000135",
                serie = "16",
                nNFIni = "10004",
                nNFFin = "10004",
                xJust = "Inutilizacao realizada para teste de integracao"
            };

            inutilizacao.EnvioSincrono(@"C:\Testes\Inutilizacao\NFe\");
        }
    }
}
