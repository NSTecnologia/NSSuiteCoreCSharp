using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Utilitarios;
using System;
using System.Collections.Generic;
using Xunit;

namespace NSSuiteCoreCSharp.Tests
{
    public class GerarPDFDocumento
    {
        [Theory]
        [MemberData(nameof(GetObjects))]
        public void GerarPDFDeXMLProcessado(IGerarPDFReq gerarPDFReq)
        {
            try
            {
                gerarPDFReq.EnviarSincrono(@"C:\NotasTeste\", true);
            }
            catch (Exception)
            {

                throw;
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
                        new GerarPDFReqNFe
                        {
                            NFeXmlProc = "<nfeProc versao=\"4.00\" xmlns=\"http://www.portalfiscal.inf.br/nfe\"><NFe><infNFe versao=\"4.00\" Id=\"NFe43200807364617000135550000000059871004621867\"><ide><cUF>43</cUF><cNF>00462186</cNF><natOp>VENDA A PRAZO - S</natOp><mod>55</mod><serie>0</serie><nNF>5987</nNF><dhEmi>2020-08-25T11:40:00-03:00</dhEmi><tpNF>1</tpNF><idDest>1</idDest><cMunFG>4305108</cMunFG><tpImp>1</tpImp><tpEmis>1</tpEmis><cDV>7</cDV><tpAmb>2</tpAmb><finNFe>1</finNFe><indFinal>1</indFinal><indPres>9</indPres><procEmi>0</procEmi><verProc>3.0 NS_CLIENT</verProc></ide><emit><CNPJ>07364617000135</CNPJ><xNome>NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL</xNome><enderEmit><xLgr>AV ANTONIO DURO</xLgr><nro>0</nro><xBairro>OLARIA</xBairro><cMun>4303509</cMun><xMun>CAMAQUA</xMun><UF>RS</UF><CEP>96180000</CEP><cPais>1058</cPais><xPais>BRASIL</xPais><fone>5112341234</fone></enderEmit><IE>0170108708</IE><CRT>3</CRT></emit><dest><CPF>02715522045</CPF><xNome>NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL</xNome><enderDest><xLgr>AV ANTONIO DURO</xLgr><nro>0</nro><xBairro>OLARIA</xBairro><cMun>4303509</cMun><xMun>CAMAQUA</xMun><UF>RS</UF><CEP>96180000</CEP><cPais>1058</cPais><xPais>BRASIL</xPais></enderDest><indIEDest>9</indIEDest></dest><det nItem=\"1\"><prod><cProd>1440859X1_</cProd><cEAN>SEM GTIN</cEAN><xProd>ABRACADEIRA</xProd><NCM>87089990</NCM><CEST>0107500</CEST><cBenef>SEM CBENEF</cBenef><CFOP>5101</CFOP><uCom>UN</uCom><qCom>1</qCom><vUnCom>12</vUnCom><vProd>12.00</vProd><cEANTrib>SEM GTIN</cEANTrib><uTrib>UN</uTrib><qTrib>1</qTrib><vUnTrib>12</vUnTrib><vDesc>1.00</vDesc><indTot>1</indTot><nItemPed>0</nItemPed></prod><imposto><vTotTrib>4.11</vTotTrib><ICMS><ICMS00><orig>0</orig><CST>00</CST><modBC>0</modBC><vBC>12.00</vBC><pICMS>18.00</pICMS><vICMS>2.16</vICMS><pFCP>2.00</pFCP><vFCP>0.24</vFCP></ICMS00></ICMS><IPI><cEnq>999</cEnq><IPINT><CST>53</CST></IPINT></IPI><PIS><PISAliq><CST>01</CST><vBC>12.00</vBC><pPIS>1.65</pPIS><vPIS>0.20</vPIS></PISAliq></PIS><COFINS><COFINSAliq><CST>01</CST><vBC>12.00</vBC><pCOFINS>7.60</pCOFINS><vCOFINS>0.91</vCOFINS></COFINSAliq></COFINS></imposto></det><total><ICMSTot><vBC>12.00</vBC><vICMS>2.16</vICMS><vICMSDeson>0.00</vICMSDeson><vFCP>0.24</vFCP><vBCST>0.00</vBCST><vST>0.00</vST><vFCPST>0.00</vFCPST><vFCPSTRet>0.00</vFCPSTRet><vProd>12.00</vProd><vFrete>0.00</vFrete><vSeg>0.00</vSeg><vDesc>1.00</vDesc><vII>0.00</vII><vIPI>0.00</vIPI><vIPIDevol>0.00</vIPIDevol><vPIS>0.20</vPIS><vCOFINS>0.91</vCOFINS><vOutro>0.00</vOutro><vNF>11.00</vNF><vTotTrib>4.11</vTotTrib></ICMSTot><retTrib><vRetPIS>0.01</vRetPIS><vRetCOFINS>0.06</vRetCOFINS></retTrib></total><transp><modFrete>1</modFrete><transporta><CNPJ>07364617000135</CNPJ><xNome>TRASPORTADORA TESTE</xNome><xEnder>ESTR BENTO OSVALDO TRISCH 777</xEnder><xMun>CAXIAS DO SUL</xMun><UF>RS</UF></transporta><vol><qVol>0</qVol><marca>TESTE</marca><nVol>0</nVol></vol></transp><pag><detPag><tPag>15</tPag><vPag>11.00</vPag></detPag></pag><infAdic><infCpl>DESCONTO PIS 0,01 COFINS 0,06 LEI 11.196 DE 21/11/2005</infCpl></infAdic></infNFe><Signature xmlns=\"http://www.w3.org/2000/09/xmldsig#\"><SignedInfo><CanonicalizationMethod Algorithm=\"http://www.w3.org/TR/2001/REC-xml-c14n-20010315\" /><SignatureMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#rsa-sha1\" /><Reference URI=\"#NFe43200807364617000135550000000059871004621867\"><Transforms><Transform Algorithm=\"http://www.w3.org/2000/09/xmldsig#enveloped-signature\" /><Transform Algorithm=\"http://www.w3.org/TR/2001/REC-xml-c14n-20010315\" /></Transforms><DigestMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#sha1\" /><DigestValue>FHcuxKbpv5fTpy7Ybd6NMQd6Jew=</DigestValue></Reference></SignedInfo><SignatureValue>I+YYCOEs9dzP1X12XBxfjxLl2x4GeBgjEBGlyCSL5Mf3kNa8kM25al8bN/oY9GiDHnt4cTFISkzgZvJW7HgL9JX+zPPCOLQtOlMnl4CadqVm5mZ5zQoRHtFvHVhLpKVZdbYs7tpHY10n6SFH5rX97CDcXpsTfE07HWjXdr5PazO/UDEFXayJnsD5vgZ55ViF5YmUECm8b6EWMcaYxW+/3i9e301FsTUh+cVWxNqJvwPLpuHJO9USS3njoUKVv/AsT6ZZVpWm5o2uuGorXTT5gsiM9zgve09aK1Ya7C4f1yJJupK6earJuqPB0Er0bOZDgROwEslDXRSr4FTfbPm+2w==</SignatureValue><KeyInfo><X509Data><X509Certificate>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</X509Certificate></X509Data></KeyInfo></Signature></NFe><protNFe versao=\"4.00\"><infProt><tpAmb>2</tpAmb><verAplic>RS202008061608</verAplic><chNFe>43200807364617000135550000000059871004621867</chNFe><dhRecbto>2020-08-25T11:41:16-03:00</dhRecbto><nProt>143200000731095</nProt><digVal>FHcuxKbpv5fTpy7Ybd6NMQd6Jew=</digVal><cStat>100</cStat><xMotivo>Autorizado o uso da NF-e</xMotivo></infProt></protNFe></nfeProc>"
                        }
                    }               
                };
            }
        }

    }
}
