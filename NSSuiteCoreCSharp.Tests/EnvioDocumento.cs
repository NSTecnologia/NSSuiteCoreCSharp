using NSSuiteCoreCSharp.src.Requisicoes.BPe.Emissoes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class EnvioDocumento
    {
        [Fact]
        public void SucessoEnvioDadoUmDocumentoValido()
        {
            var dataEmissao = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            
            var bpe = new EnvioReqBPe
            {
                infBPe = new TBPeInfBPe
                {
                    versao = "1.00",
                    ide = new TBPeInfBPeIde
                    {
                        cUF = TCodUfIBGE.RS,
                        tpAmb = TAmb.Homologacao,
                        mod = TModBPe.BPe,
                        serie = "6",
                        nBP = "65",
                        modal = TBPeInfBPeIdeModal.Rodoviario,
                        dhEmi = dataEmissao,
                        tpEmis = TBPeInfBPeIdeTpEmis.Normal,
                        verProc = "1.00",
                        tpBPe = TBPeInfBPeIdeTpBPe.Normal,
                        indPres = TIndPres.OpPresencialNaoEmbarcado,
                        UFIni = TUf_sem_EX.RS,
                        cMunIni = "4314902",
                        UFFim = TUf.PR,
                        cMunFim = "4106902"
                    },
                    emit = new TBPeInfBPeEmit
                    {
                        CNPJ = "07364617000135",
                        IE = "0170108708",
                        xNome = "EMPRESA TESTE",
                        IM = "516830",
                        CNAE = "1234567",
                        CRT = TBPeInfBPeEmitCRT.SimplesNacional,
                        enderEmit = new TEndeEmi
                        {
                            xLgr = "RUA ANTONIO DURO",
                            nro = "870",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf_sem_EX.RS
                        },
                        TAR = "113645236"
                    },
                    comp = new TBPeInfBPeComp
                    {
                        xNome = "JOHN DOE",
                        CPF = "11111111111",
                        enderComp = new TEndereco
                        {
                            xLgr = "RUA ANDRADAS EM CURITIBANAS",
                            nro = "870",
                            xBairro = "CENTRO",
                            cMun = "4106902",
                            xMun = "CURITIBA",
                            UF = TUf.PR
                        }
                    },
                    agencia = new TBPeInfBPeAgencia
                    {
                        xNome = "AGENCIA LTDA",
                        CNPJ = "07364617000135",
                        enderAgencia = new TEndereco
                        {
                            xLgr = "Largo Vespasiano Julio Veppo",
                            nro = "870",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS
                        }
                    },
                    infPassagem = new TBPeInfBPeInfPassagem
                    {
                        cLocOrig = "4314902",
                        xLocOrig = "PORTO ALEGRE",
                        cLocDest = "PR",
                        xLocDest = "CURITIBA",
                        dhEmb = dataEmissao,
                        dhValidade = DateTime.Now.AddYears(1).ToString("yyyy-MM-ddTHH:mm:sszzz"),
                        infPassageiro = new TBPeInfBPeInfPassagemInfPassageiro
                        {
                            xNome = "JOHN DOE",
                            CPF = "00269925074",
                            tpDoc = TDoc.RG,
                            nDoc = "3076507718"
                        }
                    },
                    infViagem = new List<TBPeInfBPeInfViagem>
                    {
                        new TBPeInfBPeInfViagem
                        {
                            cPercurso = "1",
                            xPercurso = "teste da descricao do percurso",
                            tpViagem = TBPeInfBPeInfViagemTpViagem.Regular,
                            tpServ = TBPeInfBPeInfViagemTpServ.Cama,
                            tpAcomodacao = TBPeInfBPeInfViagemTpAcomodacao.Assento_Poltrona,
                            tpTrecho = TBPeInfBPeInfViagemTpTrecho.Normal,
                            dhViagem = dataEmissao,
                            poltrona = "5"
                        }
                    },
                    infValorBPe = new TBPeInfBPeInfValorBPe
                    {
                        vBP = "85.00",
                        vDesconto = "0.00",
                        vPgto = "85.00",
                        vTroco = "0.00",
                        Comp = new List<TBPeInfBPeInfValorBPeComp>
                        {
                            new TBPeInfBPeInfValorBPeComp
                            {
                                tpComp = TBPeInfBPeInfValorBPeCompTpComp.Tarifa,
                                vComp = "65.00"
                            },
                            new TBPeInfBPeInfValorBPeComp
                            {
                                tpComp = TBPeInfBPeInfValorBPeCompTpComp.Pedagio,
                                vComp = "20.00"
                            }
                        }
                    },
                    imp = new TBPeInfBPeImp
                    {
                        ICMS = new TBPeInfBPeImpICMS
                        {
                            ICMS00 = new TBPeInfBPeImpICMSICMS00
                            {
                                CST = TBPeInfBPeImpICMSICMS00CST.CST00,
                                vBC = "85.00",
                                pICMS = "10",
                                vICMS = "8.50"
                            }
                        },
                        ICMSUFFim = new TBPeInfBPeImpICMSUFFim
                        {
                            vBCUFFim = "10.00",
                            pFCPUFFim = "0.85",
                            pICMSUFFim = "0.85",
                            pICMSInter = "0.85",
                            vFCPUFFim = "1",
                            vICMSUFFim = "1",
                            vICMSUFIni = "1"
                        }
                    },
                    pag = new List<TBPeInfBPePag>
                    {
                        new TBPeInfBPePag
                        {
                            tPag = TBPeInfBPePagTPag.Dinheiro,
                            vPag = "85.00"
                        }
                    },
                    infRespTec = new TRespTec
                    {
                        CNPJ = "07364617000135",
                        xContato = "Luciano",
                        email = "luciano.languer@nstecnologia.com.br",
                        fone = "5136921123"
                    }
                }
            };

            var resposta = bpe.Envia();
            Assert.Equal("200", resposta.status);
            
        }
        [Fact]
        public void ErroNoEnvioDadoUmDocumentoInvalido()
        {

        }
    }
}
