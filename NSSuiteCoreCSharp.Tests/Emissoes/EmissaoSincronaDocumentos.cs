using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using System;
using System.Collections.Generic;
using Xunit;

namespace NSSuiteCoreCSharp.Tests.Emissoes
{
    public class EmissaoSincronaDocumentos
    {

        [Theory()]
        [MemberData(nameof(GetNFe))]
        public void RealizaUmaEmissaoSincronaDadoUmDFe(IEmissaoDFeSincrona dfe)
        {
            try
            {
                dfe.EnvioSincrono(TipoDownloadDFes.XML_PDF, @"C:\Testes\EmissaoSincrona\NFe", true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static IEnumerable<object[]> GetNFe
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
                                    cUF = TCodUfIBGE.RS,
                                    cNF = "00462186",
                                    natOp = "VENDA A PRAZO - S",
                                    mod = TMod.NFe,
                                    serie = "6",
                                    nNF = "101",
                                    dhEmi = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                                    tpNF = TNFeInfNFeIdeTpNF.Saida,
                                    idDest = TNFeInfNFeIdeIdDest.OpInterna,
                                    cMunFG = "4305108",
                                    tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
                                    tpAmb = TAmb.Homologacao,
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
                                    enderDest = new TEndereco
                                    {
                                        xLgr = "AV ANTONIO DURO",
                                        nro = "0",
                                        xBairro = "OLARIA",
                                        cMun = "4303509",
                                        xMun = "CAMAQUA",
                                        UF = TUf.RS,
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
                    }
                };
            }
        }
    }
}
