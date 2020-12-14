using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class PreviaDocumento
    {
        [Theory]
        [MemberData(nameof(GetObjects))]
        public void RealizaUmaEmissaoSincronaDadoUmDFe(IPreviaReq dfe)
        {
            try
            {
                dfe.MostrarDFePreviaPDF();
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
                        new EnvioReqNFe
                        {
                            infNFe = new TNFeInfNFe
                            {
                                versao = "4.00",
                                ide = new TNFeInfNFeIde
                                {
                                    cUF = Library.src.Requisicoes.NFe.Emissoes.TCodUfIBGE.RS,
                                    cNF = "00462186",
                                    natOp = "VENDA A PRAZO - S",
                                    mod = TMod.NFe,
                                    serie = "6",
                                    nNF = "1012",
                                    dhEmi = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                                    tpNF = TNFeInfNFeIdeTpNF.Saida,
                                    idDest = TNFeInfNFeIdeIdDest.OpInterna,
                                    cMunFG = "4305108",
                                    tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
                                    tpAmb = Library.src.Requisicoes.NFe.Emissoes.TAmb.Homologacao,
                                    finNFe = TFinNFe.Normal,
                                    indFinal = TNFeInfNFeIdeIndFinal.ConsumidorFinal,
                                    indPres = TNFeInfNFeIdeIndPres.Outros,
                                    procEmi = TProcEmi.AplicativoContribuinte,
                                    verProc = "4.00"
                                },
                                emit = new TNFeInfNFeEmit
                                {
                                    CNPJ = "07364617000135",
                                    xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                                    enderEmit = new TEnderEmi
                                    {
                                        xLgr = "Rua Bento Osvaldo Trisch",
                                        nro = "777",
                                        xCpl = "CX POSTAL 91",
                                        xBairro = "Pendancino",
                                        cMun = "4303509",
                                        xMun = "Caxias do Sul",
                                        UF = TUfEmi.RS,
                                        CEP = "95046600"
                                    },
                                    IE = "0170108708",
                                    CRT = TNFeInfNFeEmitCRT.SimplesNacional
                                },
                                dest = new TNFeInfNFeDest
                                {
                                    CNPJ = "07364617000135",
                                    xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                                    enderDest = new Library.src.Requisicoes.NFe.Emissoes.TEndereco
                                    {
                                        xLgr = "AV ANTONIO DURO",
                                        nro = "0",
                                        xBairro = "OLARIA",
                                        cMun = "4303509",
                                        xMun = "CAMAQUA",
                                        UF = Library.src.Requisicoes.NFe.Emissoes.TUf.RS,
                                        CEP = "96180000",
                                        cPais = "1058",
                                        xPais = "BRASIL"
                                    },
                                    indIEDest = TNFeInfNFeDestIndIEDest.ContribuinteICMS,
                                    IE = "0170108708"
                                },
                                det = new List<TNFeInfNFeDet>
                                    {
                                        new TNFeInfNFeDet
                                        {
                                            nItem = "1",
                                            prod = new TNFeInfNFeDetProd
                                            {
                                                cProd = "1440859X1_",
                                                cEAN = "SEM GTIN",
                                                xProd = "TESTE",
                                                NCM = "87089990",
                                                CEST = "0107500",
                                                CFOP = "5101",
                                                uCom = "UN",
                                                qCom = "1.0000",
                                                vUnCom = "13.50",
                                                vProd = "13.50",
                                                cEANTrib = "SEM GTIN",
                                                uTrib = "UN",
                                                qTrib = "1.0000",
                                                vUnTrib = "13.50",
                                                indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                                nItemPed = "0",
                                                cBenef = "SEM CBENEF"
                                            },
                                            imposto = new TNFeInfNFeDetImposto
                                            {
                                                vTotTrib = "0.00",
                                                ICMS = new TNFeInfNFeDetImpostoICMS
                                                {
                                                    ICMSSN102 = new TNFeInfNFeDetImpostoICMSICMSSN102
                                                    {
                                                        orig = Torig.Nacional,
                                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN102CSOSN.CSOSN102
                                                    }
                                                },
                                                IPI = new TIpi
                                                {
                                                    cEnq = "341",
                                                    IPINT = new TIpiIPINT
                                                    {
                                                        CST = TIpiIPINTCST.CST02
                                                    }
                                                },
                                                PIS = new TNFeInfNFeDetImpostoPIS
                                                {
                                                    PISAliq = new TNFeInfNFeDetImpostoPISPISAliq
                                                    {
                                                        CST = TNFeInfNFeDetImpostoPISPISAliqCST.CST01,
                                                        vBC = "0.00",
                                                        pPIS = "0.00",
                                                        vPIS = "0.00"
                                                    }
                                                },
                                                COFINS = new TNFeInfNFeDetImpostoCOFINS
                                                {
                                                    COFINSAliq = new TNFeInfNFeDetImpostoCOFINSCOFINSAliq
                                                    {
                                                        CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.CST01,
                                                        vBC = "0.00",
                                                        pCOFINS = "0.00",
                                                        vCOFINS = "0.00"
                                                    }
                                                }
                                            }
                                        }
                                    },
                                total = new TNFeInfNFeTotal
                                {
                                    ICMSTot = new TNFeInfNFeTotalICMSTot
                                    {
                                        vBC = "0.00",
                                        vICMS = "0.00",
                                        vICMSDeson = "0.00",
                                        vFCPUFDest = "0.00",
                                        vICMSUFDest = "0.00",
                                        vICMSUFRemet = "0.00",
                                        vFCP = "0.00",
                                        vBCST = "0.00",
                                        vST = "0.00",
                                        vFCPST = "0.00",
                                        vFCPSTRet = "0.00",
                                        vProd = "13.50",
                                        vFrete = "0.00",
                                        vSeg = "0.00",
                                        vDesc = "0.00",
                                        vII = "0.00",
                                        vIPI = "0.00",
                                        vIPIDevol = "0.00",
                                        vPIS = "0.00",
                                        vCOFINS = "0.00",
                                        vOutro = "0.00",
                                        vNF = "13.50",
                                        vTotTrib = "0.00"
                                    }
                                },
                                transp = new TNFeInfNFeTransp
                                {
                                    modFrete = TNFeInfNFeTranspModFrete.SemTransporte
                                },
                                pag = new TNFeInfNFePag
                                {
                                    detPag = new List<TNFeInfNFePagDetPag>
                                        {
                                            new TNFeInfNFePagDetPag
                                            {
                                                indPag = TNFeInfNFePagDetPagIndPag.PagamanetoAVista,
                                                tPag = TNFeInfNFePagDetPagTPag.Dinheiro,
                                                vPag = "13.50"
                                            }
                                        },
                                    vTroco = "0.00"
                                },
                                infAdic = new TNFeInfNFeInfAdic
                                {
                                    infCpl = "DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL#BR#NÃO GERA DIREITO A CRÉDITO FISCAL DE ICMS, DE ISS E DE IPI#BR#"
                                }
                            }
                        }
                    },
                    
                    //BPe
                    //new object[]
                    //{
                    //    new EnvioReqBPe
                    //    {
                    //        infBPe = new TBPeInfBPe
                    //        {
                    //            versao = "1.00",
                    //            ide = new TBPeInfBPeIde
                    //            {
                    //                cUF = src.Requisicoes.BPe.Emissoes.TCodUfIBGE.RS,
                    //                tpAmb = src.Requisicoes.BPe.Emissoes.TAmb.Homologacao,
                    //                mod = TModBPe.BPe,
                    //                serie = "6",
                    //                nBP = "97",
                    //                modal = TBPeInfBPeIdeModal.Rodoviario,
                    //                dhEmi = dataEmissao,
                    //                tpEmis = TBPeInfBPeIdeTpEmis.Normal,
                    //                verProc = "1.00",
                    //                tpBPe = TBPeInfBPeIdeTpBPe.Normal,
                    //                indPres = TIndPres.OpPresencialNaoEmbarcado,
                    //                UFIni = TUf_sem_EX.RS,
                    //                cMunIni = "4314902",
                    //                UFFim = src.Requisicoes.BPe.Emissoes.TUf.PR,
                    //                cMunFim = "4106902"
                    //            },
                    //            emit = new TBPeInfBPeEmit
                    //            {
                    //                CNPJ = "07364617000135",
                    //                IE = "0170108708",
                    //                xNome = "EMPRESA TESTE",
                    //                IM = "516830",
                    //                CNAE = "1234567",
                    //                CRT = TBPeInfBPeEmitCRT.SimplesNacional,
                    //                enderEmit = new TEndeEmi
                    //                {
                    //                    xLgr = "RUA ANTONIO DURO",
                    //                    nro = "870",
                    //                    xBairro = "CENTRO",
                    //                    cMun = "4303509",
                    //                    xMun = "CAMAQUA",
                    //                    UF = TUf_sem_EX.RS
                    //                },
                    //                TAR = "113645236"
                    //            },
                    //            comp = new TBPeInfBPeComp
                    //            {
                    //                xNome = "JOHN DOE",
                    //                CPF = "11111111111",
                    //                enderComp = new src.Requisicoes.BPe.Emissoes.TEndereco
                    //                {
                    //                    xLgr = "RUA ANDRADAS EM CURITIBANAS",
                    //                    nro = "870",
                    //                    xBairro = "CENTRO",
                    //                    cMun = "4106902",
                    //                    xMun = "CURITIBA",
                    //                    UF = src.Requisicoes.BPe.Emissoes.TUf.PR
                    //                }
                    //            },
                    //            agencia = new TBPeInfBPeAgencia
                    //            {
                    //                xNome = "AGENCIA LTDA",
                    //                CNPJ = "07364617000135",
                    //                enderAgencia = new src.Requisicoes.BPe.Emissoes.TEndereco
                    //                {
                    //                    xLgr = "Largo Vespasiano Julio Veppo",
                    //                    nro = "870",
                    //                    xBairro = "CENTRO",
                    //                    cMun = "4303509",
                    //                    xMun = "CAMAQUA",
                    //                    UF = src.Requisicoes.BPe.Emissoes.TUf.RS
                    //                }
                    //            },
                    //            infPassagem = new TBPeInfBPeInfPassagem
                    //            {
                    //                cLocOrig = "4314902",
                    //                xLocOrig = "PORTO ALEGRE",
                    //                cLocDest = "PR",
                    //                xLocDest = "CURITIBA",
                    //                dhEmb = dataEmissao,
                    //                dhValidade = DateTime.Now.AddYears(1).ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    //                infPassageiro = new TBPeInfBPeInfPassagemInfPassageiro
                    //                {
                    //                    xNome = "JOHN DOE",
                    //                    CPF = "00269925074",
                    //                    tpDoc = TDoc.RG,
                    //                    nDoc = "3076507718"
                    //                }
                    //            },
                    //            infViagem = new List<TBPeInfBPeInfViagem>
                    //            {
                    //                new TBPeInfBPeInfViagem
                    //                {
                    //                    cPercurso = "1",
                    //                    xPercurso = "teste da descricao do percurso",
                    //                    tpViagem = TBPeInfBPeInfViagemTpViagem.Regular,
                    //                    tpServ = TBPeInfBPeInfViagemTpServ.Cama,
                    //                    tpAcomodacao = TBPeInfBPeInfViagemTpAcomodacao.Assento_Poltrona,
                    //                    tpTrecho = TBPeInfBPeInfViagemTpTrecho.Normal,
                    //                    dhViagem = dataEmissao,
                    //                    poltrona = "5"
                    //                }
                    //            },
                    //            infValorBPe = new TBPeInfBPeInfValorBPe
                    //            {
                    //                vBP = "85.00",
                    //                vDesconto = "0.00",
                    //                vPgto = "85.00",
                    //                vTroco = "0.00",
                    //                Comp = new List<TBPeInfBPeInfValorBPeComp>
                    //                {
                    //                    new TBPeInfBPeInfValorBPeComp
                    //                    {
                    //                        tpComp = TBPeInfBPeInfValorBPeCompTpComp.Tarifa,
                    //                        vComp = "65.00"
                    //                    },
                    //                    new TBPeInfBPeInfValorBPeComp
                    //                    {
                    //                        tpComp = TBPeInfBPeInfValorBPeCompTpComp.Pedagio,
                    //                        vComp = "20.00"
                    //                    }
                    //                }
                    //            },
                    //            imp = new TBPeInfBPeImp
                    //            {
                    //                ICMS = new TBPeInfBPeImpICMS
                    //                {
                    //                    ICMS00 = new TBPeInfBPeImpICMSICMS00
                    //                    {
                    //                        CST = TBPeInfBPeImpICMSICMS00CST.CST00,
                    //                        vBC = "85.00",
                    //                        pICMS = "10",
                    //                        vICMS = "8.50"
                    //                    }
                    //                },
                    //                ICMSUFFim = new TBPeInfBPeImpICMSUFFim
                    //                {
                    //                    vBCUFFim = "10.00",
                    //                    pFCPUFFim = "0.85",
                    //                    pICMSUFFim = "0.85",
                    //                    pICMSInter = "0.85",
                    //                    vFCPUFFim = "1",
                    //                    vICMSUFFim = "1",
                    //                    vICMSUFIni = "1"
                    //                }
                    //            },
                    //            pag = new List<TBPeInfBPePag>
                    //            {
                    //                new TBPeInfBPePag
                    //                {
                    //                    tPag = TBPeInfBPePagTPag.Dinheiro,
                    //                    vPag = "85.00"
                    //                }
                    //            },
                    //            infRespTec = new TRespTec
                    //            {
                    //                CNPJ = "07364617000135",
                    //                xContato = "Luciano",
                    //                email = "luciano.languer@nstecnologia.com.br",
                    //                fone = "5136921123"
                    //            }
                    //        }
                    //    }
                    //}
                };
            }
        }

    }
}
