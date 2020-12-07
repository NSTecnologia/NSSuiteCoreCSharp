using NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Emissoes;
using NSSuiteCSharpLib.Genericos.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class ConsultaDocumento
    {
        [Fact]
        public void SucessoAConsultarDadoUmNSNRecValido()
        {
            var consultaRequisicao = new ConsStatusProcessamentoReqBPe
            {
                CNPJ = "07364617000135",
                tpAmb = 2,
                nsNRec = "58096"
            };
            var resposta = consultaRequisicao.Envia();
            resposta.Valida();
            Assert.Equal("200", resposta.status);
        }
        [Fact]
        public void ErroAConsultarDadoUmNSNRecValido()
        {
            var consultaRequisicao = new ConsStatusProcessamentoReqBPe
            {
                CNPJ = "07364617000135",
                tpAmb = 2,
                nsNRec = "58096"
            };
            var resposta = consultaRequisicao.Envia();
            Assert.Throws<RequisicaoConsultaEmissaoException>(() => resposta.Valida());
        }

    }
}
