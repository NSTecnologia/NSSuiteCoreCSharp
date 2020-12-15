using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes.NFe.Emissoes;
using NSSuiteCoreCSharp.Respostas.NFe.Emissoes;
using NSSuiteCSharpLib.Requisicoes.NFe.Emissoes;
using NSSuiteCSharpLib.Respostas.NFe;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.NFe.Emissoes
{
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        public SignedInfoType SignedInfo { get; set; }

        public SignatureValueType SignatureValue { get; set; }

        public KeyInfoType KeyInfo { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod { get; set; }

        public SignedInfoTypeSignatureMethod SignatureMethod { get; set; }

        public ReferenceType Reference { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;

        public SignedInfoTypeCanonicalizationMethod()
        {
            algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

         [XmlElement(DataType = "base64Binary")]
        public byte[] X509Certificate { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {
        /// <remarks/>
        public X509DataType X509Data { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {
        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {
        [XmlElement("XPath")]
        public string[] XPath { get; set; }

        [XmlAttribute()]
        [JsonIgnore()]
        public TTransformURI Algorithm { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [XmlEnum("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [XmlEnum("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {
        /// <remarks/>
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }

        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] DigestValue { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;

        public ReferenceTypeDigestMethod()
        {
            algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;

        public SignedInfoTypeSignatureMethod()
        {
            algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return algorithmField;
            }
            set
            {
                algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRoot("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    [JsonObject("NFe")]
    public partial class EnvioReqNFe : SolicitavelNaAPI, IEmissaoDFeSincrona, IPreviaReq
    {
        public TNFeInfNFe infNFe { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeSupl infNFeSupl { get; set; }

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [JsonIgnore()]
        public SignatureType Signature { get; set; }


        public IResposta Envia()
        {
            const string requestURL = "https://nfe.ns.eti.br/nfe/issue";

            Util.GravarLinhaLog("[ENVIO_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[ENVIO_NFE_FIM]");

            return JsonConvert.DeserializeObject<EnvioRespNFe>(resposta);
        }
        public void EnvioSincrono(TipoDownloadDFes tpDown, string caminho, bool exibirNaTela, bool a3 = false)
        {
            Util.GravarLinhaLog("[INICIO_EMISSAO_SINCRONA_NFE]");

            IResposta envioResposta = this.Envia();
            envioResposta.Valida();

            var consultaRequisicao = new ConsStatusProcessamentoReqNFe
            {
                CNPJ = infNFe.emit.CNPJ,
                tpAmb = infNFe.ide.tpAmb,
                nsNRec = (envioResposta as EnvioRespNFe).nsNRec
            };

            IResposta consultaResposta;
            while (true)
            {
                consultaResposta = consultaRequisicao.Envia();
                try
                {
                    consultaResposta.Valida();
                    break;
                }
                catch (InvalidOperationException)
                {
                    continue;
                }
            }

            var downloadRequisicao = new DownloadReqNFe
            {
                tpDown = tpDown,
                tpAmb = infNFe.ide.tpAmb,
                chNFe = (consultaResposta as ConsStatusProcessamentoRespNFe).chNFe
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadRespNFe;
            downloadResposta.ValidarESalvar(caminho, exibirNaTela);

            Util.GravarLinhaLog("[FIM_EMISSAO_SINCRONA_NFE]");
        }

        public IPreviaResp MostrarDFePreviaPDF()
        {
            const string requestURL = "https://nfe.ns.eti.br/util/preview/nfe";

            Util.GravarLinhaLog("[PREVIA_NFE_INICIO]");
            string resposta = EnviaConteudoParaAPI(this, requestURL);
            Util.GravarLinhaLog("[PREVIA_NFE_FIM]");
            var previaResp = JsonConvert.DeserializeObject<PreviaRespNFe>(resposta);
            previaResp.ValidarEMostrar();

            return previaResp;
        }

        public override string ToJSONString()
        {
            JObject root = JObject.FromObject(new { NFe = this });
            return JsonConvert.SerializeObject(
                root,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }
            );
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe
    {
        public TNFeInfNFeIde ide { get; set; }

        public TNFeInfNFeEmit emit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeAvulsa avulsa { get; set; }

        /// <remarks/>
        public TNFeInfNFeDest dest { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TLocal retirada { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TLocal entrega { get; set; }

        /// <remarks/>
        [XmlElement("autXML")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TNFeInfNFeAutXML> autXML { get; set; }

        /// <remarks/>
        [XmlElement("det")]
        public List<TNFeInfNFeDet> det { get; set; }

        /// <remarks/>
        public TNFeInfNFeTotal total { get; set; }
        /// <remarks/>
        public TNFeInfNFeTransp transp { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeCobr cobr { get; set; }

        /// <remarks/>
        public TNFeInfNFePag pag { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeInfAdic infAdic { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeExporta exporta { get; set; }

        /// <remarks/>
        public TNFeInfNFeCompra compra { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeCana cana { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TInfRespTec infRespTec { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string versao { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TCodUfIBGE cUF { get; set; }

        /// <remarks/>
        public string cNF { get; set; }

        /// <remarks/>
        public string natOp { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TMod mod { get; set; }

        /// <remarks/>
        public string serie { get; set; }

        /// <remarks/>
        public string nNF { get; set; }

        /// <remarks/>
        public string dhEmi { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dhSaiEnt { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeTpNF tpNF { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeIdDest idDest { get; set; }

        /// <remarks/>
        public string cMunFG { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeTpImp tpImp { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeTpEmis tpEmis { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cDV { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TAmb tpAmb { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TFinNFe finNFe { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeIndFinal indFinal { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeIndPres indPres { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TProcEmi procEmi { get; set; }

        /// <remarks/>
        public string verProc { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dhCont { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xJust { get; set; }

        /// <remarks/>
        [XmlElement("NFref")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TNFeInfNFeIdeNFref> NFref { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCodUfIBGE
    {

        /// <remarks/>
        [EnumMember(Value = "11")]
        [XmlEnum("11")]
        RO,

        /// <remarks/>
        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        AC,

        /// <remarks/>
        [EnumMember(Value = "13")]
        [XmlEnum("13")]
        AM,

        /// <remarks/>
        [EnumMember(Value = "14")]
        [XmlEnum("14")]
        RR,

        /// <remarks/>
        [EnumMember(Value = "15")]
        [XmlEnum("15")]
        PA,

        /// <remarks/>
        [EnumMember(Value = "16")]
        [XmlEnum("16")]
        AP,

        /// <remarks/>
        [EnumMember(Value = "17")]
        [XmlEnum("17")]
        TO,

        /// <remarks/>
        [EnumMember(Value = "21")]
        [XmlEnum("21")]
        MA,

        /// <remarks/>
        [EnumMember(Value = "22")]
        [XmlEnum("22")]
        PI,

        /// <remarks/>
        [EnumMember(Value = "23")]
        [XmlEnum("23")]
        CE,

        /// <remarks/>
        [EnumMember(Value = "24")]
        [XmlEnum("24")]
        RN,

        /// <remarks/>
        [EnumMember(Value = "25")]
        [XmlEnum("25")]
        PB,

        /// <remarks/>
        [EnumMember(Value = "26")]
        [XmlEnum("26")]
        PE,

        /// <remarks/>
        [EnumMember(Value = "27")]
        [XmlEnum("27")]
        AL,

        /// <remarks/>
        [EnumMember(Value = "28")]
        [XmlEnum("28")]
        SE,

        /// <remarks/>
        [EnumMember(Value = "29")]
        [XmlEnum("29")]
        BA,

        /// <remarks/>
        [EnumMember(Value = "31")]
        [XmlEnum("31")]
        MG,

        /// <remarks/>
        [EnumMember(Value = "32")]
        [XmlEnum("32")]
        ES,

        /// <remarks/>
        [EnumMember(Value = "33")]
        [XmlEnum("33")]
        RJ,

        /// <remarks/>
        [EnumMember(Value = "35")]
        [XmlEnum("35")]
        SP,

        /// <remarks/>
        [EnumMember(Value = "41")]
        [XmlEnum("41")]
        PR,

        /// <remarks/>
        [EnumMember(Value = "42")]
        [XmlEnum("42")]
        SC,

        /// <remarks/>

        [EnumMember(Value = "43")]
        [XmlEnum("43")]
        RS,

        /// <remarks/>

        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        MS,

        /// <remarks/>
        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        MT,

        /// <remarks/>
        [EnumMember(Value = "52")]
        [XmlEnum("52")]
        GO,

        /// <remarks/>
        [EnumMember(Value = "53")]
        [XmlEnum("53")]
        DF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TMod
    {

        /// <remarks/>
        [EnumMember(Value = "55")]
        [XmlEnum("55")]
        NFe,

        /// <remarks/>
        [EnumMember(Value = "65")]
        [XmlEnum("65")]
        NFCe,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpNF
    {

        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Entrata,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Saida,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIdDest
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        OpInterna,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        OpInterestadual,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        OpExterior,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpImp
    {

        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        SemDANFE,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        DANFERetrato,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        DANFEPaisagem,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        DANFESimplificado,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        DANFENFCe,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        DANFENFCeMsgEletronica,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Normal,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ContigenciaFSIA,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ContigenciaSCAN,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        ContigenciaDPEC,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        ContigenciaFSDA,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ContigenciaSVCAN,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        ContigenciaSVNRS,

        /// <remarks/>
        [EnumMember(Value = "8")]
        [XmlEnum("9")]
        ContigenciaOffline,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Producao,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Homologacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TFinNFe
    {
        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Normal,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Complementar,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Ajuste,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Devolucao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndFinal
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Nao,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ConsumidorFinal,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPres
    {

        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        NaoAplica,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Presencial,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Internet,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Teleatendimento,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        NFCEntregaDomicilio,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        PresencialForaEstabelecimento,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TProcEmi
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        AplicativoContribuinte,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        AvulsaPeloFisco,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        SiteFisco,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        AplicativoFisco,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFref
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string refCTe { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeIdeNFrefRefECF refECF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeIdeNFrefRefNF refNF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeIdeNFrefRefNFP refNFP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string refNFe { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeNFrefRefECFMod mod { get; set; }

        /// <remarks/>
        public string nECF { get; set; }

        /// <remarks/>
        public string nCOO { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {

        /// <remarks/>
        [EnumMember(Value = "2B")]
        [XmlEnum("2B")]
        Item2B,

        /// <remarks/>
        [EnumMember(Value = "2C")]
        [XmlEnum("2C")]
        Item2C,

        /// <remarks/>
        [EnumMember(Value = "2D")]
        [XmlEnum("2D")]
        Item2D,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TCodUfIBGE cUF { get; set; }

        /// <remarks/>
        public string AAMM { get; set; }

        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeNFrefRefNFMod mod { get; set; }

        /// <remarks/>
        public string serie { get; set; }

        /// <remarks/>
        public string nNF { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {

        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Modelo01,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Modelo02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TCodUfIBGE cUF { get; set; }

        /// <remarks/>
        public string AAMM { get; set; }

        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        public string CPF { get; set; }

        /// <remarks/>
        public string IE { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeIdeNFrefRefNFPMod mod { get; set; }

        /// <remarks/>
        public string serie { get; set; }

        /// <remarks/>
        public string nNF { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {

        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        NF,

        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        NFProdutor,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        /// <remarks/>
        public string xNome { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xFant { get; set; }

        /// <remarks/>
        public TEnderEmi enderEmit { get; set; }

        /// <remarks/>
        public string IE { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IEST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNAE { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeEmitCRT CRT { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEnderEmi
    {
        /// <remarks/>
        public string xLgr { get; set; }

        /// <remarks/>
        public string nro { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl { get; set; }

        /// <remarks/>
        public string xBairro { get; set; }

        /// <remarks/>
        public string cMun { get; set; }

        /// <remarks/>
        public string xMun { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUfEmi UF { get; set; }

        /// <remarks/>
        public string CEP { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TEnderEmiCPais cPais { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool cPaisSpecified { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TEnderEmiXPais xPais { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool xPaisSpecified { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUfEmi
    {

        /// <remarks/>
        [EnumMember(Value = "AC")]
        AC,

        /// <remarks/>
        [EnumMember(Value = "AL")]
        AL,

        /// <remarks/>
        [EnumMember(Value = "AM")]
        AM,

        /// <remarks/>
        [EnumMember(Value = "AP")]
        AP,

        /// <remarks/>
        [EnumMember(Value = "BA")]
        BA,

        /// <remarks/>
        [EnumMember(Value = "CE")]
        CE,

        /// <remarks/>
        [EnumMember(Value = "DF")]
        DF,

        /// <remarks/>
        [EnumMember(Value = "ES")]
        ES,

        /// <remarks/>
        [EnumMember(Value = "Go")]
        GO,

        /// <remarks/>
        [EnumMember(Value = "MA")]
        MA,

        /// <remarks/>
        [EnumMember(Value = "MG")]
        MG,

        /// <remarks/>
        [EnumMember(Value = "MS")]
        MS,

        /// <remarks/>
        [EnumMember(Value = "MT")]
        MT,

        /// <remarks/>
        [EnumMember(Value = "PA")]
        PA,

        /// <remarks/>
        [EnumMember(Value = "PB")]
        PB,

        /// <remarks/>
        [EnumMember(Value = "PE")]
        PE,

        /// <remarks/>
        [EnumMember(Value = "PI")]
        PI,

        /// <remarks/>
        [EnumMember(Value = "PR")]
        PR,

        /// <remarks/>
        [EnumMember(Value = "RJ")]
        RJ,

        /// <remarks/>
        [EnumMember(Value = "RN")]
        RN,

        /// <remarks/>
        [EnumMember(Value = "RO")]
        RO,

        /// <remarks/>
        [EnumMember(Value = "RR")]
        RR,

        /// <remarks/>
        [EnumMember(Value = "RS")]
        RS,

        /// <remarks/>
        [EnumMember(Value = "SC")]
        SC,

        /// <remarks/>
        [EnumMember(Value = "SE")]
        SE,

        /// <remarks/>
        [EnumMember(Value = "SP")]
        SP,

        /// <remarks/>
        [EnumMember(Value = "TO")]
        TO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiCPais
    {

        /// <remarks/>
        [EnumMember(Value = "1058")]
        [XmlEnum("1058")]
        BRASIL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiXPais
    {

        /// <remarks/>
        [EnumMember(Value = "Brasil")]
        Brasil,

        /// <remarks/>
        [EnumMember(Value = "BRASIL")]
        BRASIL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        SimplesNacional,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        SNExcessoRC,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        RegimeNormal,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa
    {
        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        public string xOrgao { get; set; }

        /// <remarks/>
        public string matr { get; set; }

        /// <remarks/>
        public string xAgente { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUfEmi UF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nDAR { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dEmi { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vDAR { get; set; }

        /// <remarks/>
        public string repEmi { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dPag { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string idEstrangeiro { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xNome { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TEndereco enderDest { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDestIndIEDest indIEDest { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IE { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ISUF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEndereco
    {
        /// <remarks/>
        public string xLgr { get; set; }

        /// <remarks/>
        public string nro { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl { get; set; }

        /// <remarks/>
        public string xBairro { get; set; }

        /// <remarks/>
        public string cMun { get; set; }

        /// <remarks/>
        public string xMun { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cPais { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xPais { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUf
    {
        /// <remarks/>
        [EnumMember(Value = "AC")]
        AC,

        /// <remarks/>
        [EnumMember(Value = "AL")]
        AL,

        /// <remarks/>
        [EnumMember(Value = "AM")]
        AM,

        /// <remarks/>
        [EnumMember(Value = "AP")]
        AP,

        /// <remarks/>
        [EnumMember(Value = "BA")]
        BA,

        /// <remarks/>
        [EnumMember(Value = "CE")]
        CE,

        /// <remarks/>
        [EnumMember(Value = "DF")]
        DF,

        /// <remarks/>
        [EnumMember(Value = "ES")]
        ES,

        /// <remarks/>
        [EnumMember(Value = "Go")]
        GO,

        /// <remarks/>
        [EnumMember(Value = "MA")]
        MA,

        /// <remarks/>
        [EnumMember(Value = "MG")]
        MG,

        /// <remarks/>
        [EnumMember(Value = "MS")]
        MS,

        /// <remarks/>
        [EnumMember(Value = "MT")]
        MT,

        /// <remarks/>
        [EnumMember(Value = "PA")]
        PA,

        /// <remarks/>
        [EnumMember(Value = "PB")]
        PB,

        /// <remarks/>
        [EnumMember(Value = "PE")]
        PE,

        /// <remarks/>
        [EnumMember(Value = "PI")]
        PI,

        /// <remarks/>
        [EnumMember(Value = "PR")]
        PR,

        /// <remarks/>
        [EnumMember(Value = "RJ")]
        RJ,

        /// <remarks/>
        [EnumMember(Value = "RN")]
        RN,

        /// <remarks/>
        [EnumMember(Value = "RO")]
        RO,

        /// <remarks/>
        [EnumMember(Value = "RR")]
        RR,

        /// <remarks/>
        [EnumMember(Value = "RS")]
        RS,

        /// <remarks/>
        [EnumMember(Value = "SC")]
        SC,

        /// <remarks/>
        [EnumMember(Value = "SE")]
        SE,

        /// <remarks/>
        [EnumMember(Value = "SP")]
        SP,

        /// <remarks/>
        [EnumMember(Value = "TO")]
        TO,
        /// <remarks/>
        [EnumMember(Value = "EX")]
        EX,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDestIndIEDest
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ContribuinteICMS,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ContribuinteIsento,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        NaoContribuinte,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TLocal
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xNome { get; set; }

        /// <remarks/>
        public string xLgr { get; set; }

        /// <remarks/>
        public string nro { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl { get; set; }

        /// <remarks/>
        public string xBairro { get; set; }

        /// <remarks/>
        public string cMun { get; set; }

        /// <remarks/>
        public string xMun { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cPais { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xPais { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IE { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAutXML
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDet
    {
        /// <remarks/>
        public TNFeInfNFeDetProd prod { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImposto imposto { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoDevol impostoDevol { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string infAdProd { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string nItem { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {
        /// <remarks/>
        public string cProd { get; set; }

        /// <remarks/>
        public string cEAN { get; set; }

        /// <remarks/>
        public string xProd { get; set; }

        /// <remarks/>
        public string NCM { get; set; }

        /// <remarks/>
        [XmlElement("NVE")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NVE { get; set; }
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdIndEscala indEscala { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool indEscalaSpecified { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJFab { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cBenef { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EXTIPI { get; set; }

        /// <remarks/>
        public string CFOP { get; set; }

        /// <remarks/>
        public string uCom { get; set; }

        /// <remarks/>
        public string qCom { get; set; }

        /// <remarks/>
        public string vUnCom { get; set; }

        /// <remarks/>
        public string vProd { get; set; }

        /// <remarks/>
        public string cEANTrib { get; set; }

        /// <remarks/>
        public string uTrib { get; set; }

        /// <remarks/>
        public string qTrib { get; set; }

        /// <remarks/>
        public string vUnTrib { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFrete { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vSeg { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vDesc { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vOutro { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdIndTot indTot { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xPed { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nItemPed { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nFCI { get; set; }

        /// <remarks/>
        [XmlElement("rastro")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TNFeInfNFeDetProdRastro> rastro { get; set; }

        /// <remarks/>
        [XmlElement("DI")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TNFeInfNFeDetProdDI> DI { get; set; }

        /// <remarks/>
        [XmlElement("detExport")]
        public List<TNFeInfNFeDetProdDetExport> detExport { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdVeicProd veicProd { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdMed med { get; set; }

        /// <remarks/>
        [XmlElement("arma")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TNFeInfNFeDetProdArma> arma { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdComb comb { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nRECOPI { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndEscala
    {
        /// <remarks/>
        [EnumMember(Value = "S")]
        S,

        /// <remarks/>
        [EnumMember(Value = "N")]
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        NaoCompoeTotal,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        CompoeTotal,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI
    {
        /// <remarks/>
        public string nDI { get; set; }

        /// <remarks/>
        public string dDI { get; set; }

        /// <remarks/>
        public string xLocDesemb { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUfEmi UFDesemb { get; set; }
        /// <remarks/>
        public string dDesemb { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vAFRMM { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TUfEmi UFTerceiro { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool UFTerceiroSpecified { get; set; }

        /// <remarks/>
        public string cExportador { get; set; }

        /// <remarks/>
        [XmlElement("adi")]
        public List<TNFeInfNFeDetProdDIAdi> adi { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpViaTransp
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Maritima,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Fluvial,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Lacustre,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Aerea,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Postal,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        Ferroviaria,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        Rodoviaria,

        /// <remarks/>
        [EnumMember(Value = "8")]
        [XmlEnum("8")]
        Conduto_RedeTrasmissao,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        MeiosProprios,

        /// <remarks/>
        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        Entrada_SaidaFicta,

        /// <remarks/>
        //[EnumMember(Value = "11")]
        //[System.Xml.Serialization.XmlEnumAttribute("11")]
        //Item11,

        /// <remarks/>
        //[EnumMember(Value = "12")]
        //[System.Xml.Serialization.XmlEnumAttribute("12")]
        //Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpIntermedio
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ContaPropria,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ContaEOrdem,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Encomenda,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDIAdi
    {
        /// <remarks/>
        public string nAdicao { get; set; }

        /// <remarks/>
        public string nSeqAdic { get; set; }

        /// <remarks/>
        public string cFabricante { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vDescDI { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nDraw { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExport
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nDraw { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdDetExportExportInd exportInd { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExportExportInd
    {
        /// <remarks/>
        public string nRE { get; set; }

        /// <remarks/>
        public string chNFe { get; set; }

        /// <remarks/>
        public string qExport { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdRastro
    {
        /// <remarks/>
        public string nLote { get; set; }

        /// <remarks/>
        public string qLote { get; set; }

        /// <remarks/>
        public string dFab { get; set; }

        /// <remarks/>
        public string dVal { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cAgreg { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdArmaTpArma tpArma { get; set; }

        /// <remarks/>
        public string nSerie { get; set; }

        /// <remarks/>
        public string nCano { get; set; }

        /// <remarks/>
        public string descr { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdArmaTpArma
    {

        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        UsoPermitido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        UsoRestrito,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdComb
    {
        /// <remarks/>
        public string cProdANP { get; set; }

        /// <remarks/>
        public string descANP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pGLP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pGNn { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pGNi { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vPart { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CODIF { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string qTemp { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TUf UFCons { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdCombCIDE CIDE { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetProdCombEncerrante encerrante { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombCIDE
    {
        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vCIDE { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombEncerrante
    {
        /// <remarks/>
        public string nBico { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nBomba { get; set; }

        /// <remarks/>
        public string nTanque { get; set; }

        /// <remarks/>
        public string vEncIni { get; set; }

        /// <remarks/>
        public string vEncFin { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdMed
    {
        /// <remarks/>
        public string cProdANVISA { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xMotivoIsencao { get; set; }

        /// <remarks/>
        public string vPMC { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdVeicProd
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdVeicProdTpOp tpOp { get; set; }

        /// <remarks/>
        public string chassi { get; set; }

        /// <remarks/>
        public string cCor { get; set; }

        /// <remarks/>
        public string xCor { get; set; }

        /// <remarks/>
        public string pot { get; set; }

        /// <remarks/>
        public string cilin { get; set; }

        /// <remarks/>
        public string pesoL { get; set; }

        /// <remarks/>
        public string pesoB { get; set; }

        /// <remarks/>
        public string nSerie { get; set; }

        /// <remarks/>
        public string tpComb { get; set; }

        /// <remarks/>
        public string nMotor { get; set; }

        /// <remarks/>
        public string CMT { get; set; }

        /// <remarks/>
        public string dist { get; set; }

        /// <remarks/>
        public string anoMod { get; set; }

        /// <remarks/>
        public string anoFab { get; set; }

        /// <remarks/>
        public string tpPint { get; set; }

        /// <remarks/>
        public string tpVeic { get; set; }

        /// <remarks/>
        public string espVeic { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdVeicProdVIN VIN { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdVeicProdCondVeic condVeic { get; set; }

        /// <remarks/>
        public string cMod { get; set; }

        /// <remarks/>
        public string cCorDENATRAN { get; set; }

        /// <remarks/>
        public string lota { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetProdVeicProdTpRest tpRest { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Outros,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        VendaConcessionaria,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        FaturamentoConsumidorFinal,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        VendaGrandesConsumidores,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {
        /// <remarks/>
        [EnumMember(Value = "R")]
        R,

        /// <remarks/>
        [EnumMember(Value = "N")]
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Acabado,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Inacabado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Semiacabado,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        NaoHa,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        AlienacaoFiduciaria,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ArrendamentoMercantil,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ReservaDominio,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        PenhorVeiculos,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outras,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vTotTrib { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMS ICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoII II { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TIpi IPI { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoISSQN ISSQN { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoPIS PIS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoPISST PISST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoCOFINS COFINS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoCOFINSST COFINSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMS
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS00 ICMS00 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS10 ICMS10 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS20 ICMS20 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS30 ICMS30 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS40 ICMS40 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS51 ICMS51 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS60 ICMS60 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS70 ICMS70 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS90 ICMS90 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSPart ICMSPart { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN101 ICMSSN101 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN102 ICMSSN102 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN201 ICMSSN201 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN202 ICMSSN202 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN500 ICMSSN500 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSSN900 ICMSSN900 { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMSST ICMSST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS00CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC { get; set; }

        /// <remarks/>
        public string vBC { get; set; }
        /// <remarks/>
        public string pICMS { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Torig
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Nacional,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        EstrangeiraImportacaoDireta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        EstrangeiraMercadoInterno,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        NacionalImportacaoSup40ouIgual70,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        NacionalAjustes,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        NacionalImportacaoIgualouInf40,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        EstrangeiraImportacaoDiretaCAMEXEGasNatural,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        EstrangeiraMercadoInternoCAMEXEGasNatural,

        /// <remarks/>
        [EnumMember(Value = "8")]
        [XmlEnum("8")]
        NacionalImportacaoSup70,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {
        /// <remarks/>
        [EnumMember(Value = "00")]
        [XmlEnum("00")]
        CST00,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS10CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pICMS { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {

        /// <remarks/>
        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        CST10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS20CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC { get; set; }

        /// <remarks/>
        public string pRedBC { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pICMS { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDeson { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {

        /// <remarks/>
        [EnumMember(Value = "20")]
        [XmlEnum("20")]
        CST20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    {

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        UsoAgropecuaria,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,

        /// <remarks/>
        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        OrgaoFomentoDevAgropecuario,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS30CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        public string vBCST { get; set; }

        /// <remarks/>
        public string pICMSST { get; set; }

        /// <remarks/>
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDeson { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {

        /// <remarks/>
        [EnumMember(Value = "30")]
        [XmlEnum("30")]
        CST30,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    {
        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        UtilitariosMotosAmazoniaEAreasLivreComercio,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        SUFRAMA,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS40CST CST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDeson { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {
        /// <remarks/>
        [EnumMember(Value = "40")]
        [XmlEnum("40")]
        CST40,

        /// <remarks/>
        [EnumMember(Value = "41")]
        [XmlEnum("41")]
        CST41,

        /// <remarks/>
        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        CST50,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Taxi,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ProdutorAgropecurio,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Frotista_Locadora,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Diplomatico_Consular,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        UtilitariosMotosAmazoniaEAreasLivreComercio,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        SUFRAMA,

        /// <remarks/>
        [EnumMember(Value = "8")]
        [XmlEnum("8")]
        VendaOrgaoPublico,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,

        /// <remarks/>
        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        DeficienteCondutor,

        /// <remarks/>
        [EnumMember(Value = "11")]
        [XmlEnum("11")]
        DeficienteNaoCondutor,

        /// <remarks/>
        [EnumMember(Value = "16")]
        [XmlEnum("16")]
        OliempiedasRio2016,

        /// <remarks/>
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        SolicitadaFiscoRevogadaVersao301,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS51CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool modBCSpecified { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSOp { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pDif { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDif { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {
        /// <remarks/>
        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        CST51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS60CST CST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSubstituto { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSEfet { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {
        /// <remarks/>
        [EnumMember(Value = "60")]
        [XmlEnum("60")]
        CST60,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS70CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBC { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pICMS { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDeson { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {
        /// <remarks/>
        [EnumMember(Value = "70")]
        [XmlEnum("70")]
        CST70,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    {
        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        UsoAgropecuaria,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,

        /// <remarks/>
        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        OrgaoFomentoDevAgropecuario,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS90CST CST { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCP { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSDeson { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {
        /// <remarks/>
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        CST90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    {
        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        UsoAgropecuaria,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,

        /// <remarks/>
        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        OrgaoFomentoDevAgropecuario,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSPartCST CST { get; set; }
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pRedBC { get; set; }

        /// <remarks/>
        public string pICMS { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        public string vBCST { get; set; }

        /// <remarks/>
        public string pICMSST { get; set; }

        /// <remarks/>
        public string vICMSST { get; set; }

        /// <remarks/>
        public string pBCOp { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UFST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {
        /// <remarks/>
        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        CST10,

        /// <remarks/>
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        CST90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN { get; set; }

        /// <remarks/>
        public string pCredSN { get; set; }

        /// <remarks/>
        public string vCredICMSSN { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "101")]
        [XmlEnum("101")]
        CSOSN101,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "102")]
        [XmlEnum("102")]
        CSOSN102,

        /// <remarks/>
        [EnumMember(Value = "103")]
        [XmlEnum("103")]
        CSOSN103,

        /// <remarks/>
        [EnumMember(Value = "300")]
        [XmlEnum("300")]
        CSOSN300,

        /// <remarks/>
        [EnumMember(Value = "400")]
        [XmlEnum("400")]
        CSOSN400,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        public string vBCST { get; set; }

        /// <remarks/>
        public string pICMSST { get; set; }

        /// <remarks/>
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pCredSN { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vCredICMSSN { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "201")]
        [XmlEnum("201")]
        CSOSN201,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        public string vBCST { get; set; }

        /// <remarks/>
        public string pICMSST { get; set; }

        /// <remarks/>
        public string vICMSST { get; set; }

        /// <remarks/>
        public string vBCFCPST { get; set; }

        /// <remarks/>
        public string pFCPST { get; set; }

        /// <remarks/>
        public string vFCPST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "202")]
        [XmlEnum("202")]
        CSOSN202,

        /// <remarks/>
        [EnumMember(Value = "203")]
        [XmlEnum("203")]
        CSOSN203,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSubstituto { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSEfet { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "500")]
        [XmlEnum("500")]
        CSOSN500,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBC { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMS { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pMVAST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pCredSN { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vCredICMSSN { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {
        /// <remarks/>
        [EnumMember(Value = "900")]
        [XmlEnum("900")]
        CST900,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        MargemValAgregado,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        PrecoMaxTabelado,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ValorDaOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PrecoTabeladoOuMaxSugerido,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ListaNegativa,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ListaPositiva,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        ListaNeutra,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        MargemValorAgregado,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Pauta,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ValorOperacao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public Torig orig { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSICMSSTCST CST { get; set; }

        /// <remarks/>
        public string vBCSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pST { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSubstituto { get; set; }

        /// <remarks/>
        public string vICMSSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vFCPSTRet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCSTDest { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSSTDest { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vBCEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pICMSEfet { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vICMSEfet { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {

        /// <remarks/>
        [EnumMember(Value = "41")]
        [XmlEnum("41")]
        CST41,

        /// <remarks/>
        [EnumMember(Value = "60")]
        [XmlEnum("60")]
        CST60,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoII
    {
        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vDespAdu { get; set; }

        /// <remarks/>
        public string vII { get; set; }

        /// <remarks/>
        public string vIOF { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpi
    {
        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.AllowNull)]
        public string CNPJProd { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.AllowNull)]
        public string cSelo { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.AllowNull)]
        public string qSelo { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
        public string cEnq { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
        public TIpiIPINT IPINT { get; set; }

        /// <remarks/>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
        public TIpiIPITrib IPITrib { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPINT
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TIpiIPINTCST CST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPINTCST
    {
        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        CST01,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        CST02,

        /// <remarks/>
        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        CST03,

        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        CST04,

        /// <remarks/>
        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        CST05,

        /// <remarks/>
        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        CST51,

        /// <remarks/>
        [EnumMember(Value = "52")]
        [XmlEnum("52")]
        CST52,

        /// <remarks/>
        [EnumMember(Value = "53")]
        [XmlEnum("53")]
        CST53,

        /// <remarks/>
        [EnumMember(Value = "54")]
        [XmlEnum("54")]
        CST54,

        /// <remarks/>
        [EnumMember(Value = "55")]
        [XmlEnum("55")]
        CST55,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPITrib
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TIpiIPITribCST CST { get; set; }

        /// <remarks/>
        public string pIPI { get; set; }

        /// <remarks/>
        public string qUnid { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vUnid { get; set; }

        /// <remarks/>
        public string vIPI { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPITribCST
    {
        /// <remarks/>
        [EnumMember(Value = "00")]
        [XmlEnum("00")]
        CST00,

        /// <remarks/>
        [EnumMember(Value = "49")]
        [XmlEnum("49")]
        CST49,

        /// <remarks/>
        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        CST50,

        /// <remarks/>
        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        CST99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoISSQN
    {
        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vAliq { get; set; }

        /// <remarks/>
        public string vISSQN { get; set; }

        /// <remarks/>
        public string cMunFG { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TCListServ cListServ { get; set; }

        /// <remarks/>
        public string vDeducao { get; set; }
        /// <remarks/>
        public string vOutro { get; set; }

        /// <remarks/>
        public string vDescIncond { get; set; }

        /// <remarks/>
        public string vDescCond { get; set; }

        /// <remarks/>
        public string vISSRet { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoISSQNIndISS indISS { get; set; }

        /// <remarks/>
        public string cServico { get; set; }

        /// <remarks/>
        public string cMun { get; set; }

        /// <remarks/>
        public string cPais { get; set; }

        /// <remarks/>
        public string nProcesso { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCListServ
    {

        /// <remarks/>
        [EnumMember(Value = "01.01")]
        [XmlEnum("01.01")]
        Item0101,

        /// <remarks/>
        [EnumMember(Value = "01.02")]
        [XmlEnum("01.02")]
        Item0102,

        /// <remarks/>
        [EnumMember(Value = "01.03")]
        [XmlEnum("01.03")]
        Item0103,

        /// <remarks/>
        [EnumMember(Value = "01.04")]
        [XmlEnum("01.04")]
        Item0104,

        /// <remarks/>
        [EnumMember(Value = "01.05")]
        [XmlEnum("01.05")]
        Item0105,

        /// <remarks/>
        [EnumMember(Value = "01.06")]
        [XmlEnum("01.06")]
        Item0106,

        /// <remarks/>
        [EnumMember(Value = "01.07")]
        [XmlEnum("01.07")]
        Item0107,

        /// <remarks/>
        [EnumMember(Value = "01.08")]
        [XmlEnum("01.08")]
        Item0108,

        /// <remarks/>
        [EnumMember(Value = "01.09")]
        [XmlEnum("01.09")]
        Item0109,

        /// <remarks/>
        [EnumMember(Value = "02.01")]
        [XmlEnum("02.01")]
        Item0201,

        /// <remarks/>
        [EnumMember(Value = "03.02")]
        [XmlEnum("03.02")]
        Item0302,

        /// <remarks/>
        [EnumMember(Value = "03.03")]
        [XmlEnum("03.03")]
        Item0303,

        /// <remarks/>
        [EnumMember(Value = "03.04")]
        [XmlEnum("03.04")]
        Item0304,

        /// <remarks/>
        [EnumMember(Value = "03.05")]
        [XmlEnum("03.05")]
        Item0305,

        /// <remarks/>
        [EnumMember(Value = "04.01")]
        [XmlEnum("04.01")]
        Item0401,

        /// <remarks/>
        [EnumMember(Value = "04.02")]
        [XmlEnum("04.02")]
        Item0402,

        /// <remarks/>
        [EnumMember(Value = "04.03")]
        [XmlEnum("04.03")]
        Item0403,

        /// <remarks/>
        [EnumMember(Value = "04.04")]
        [XmlEnum("04.04")]
        Item0404,

        /// <remarks/>
        [EnumMember(Value = "04.05")]
        [XmlEnum("04.05")]
        Item0405,

        /// <remarks/>
        [EnumMember(Value = "04.06")]
        [XmlEnum("04.06")]
        Item0406,

        /// <remarks/>
        [EnumMember(Value = "04.07")]
        [XmlEnum("04.07")]
        Item0407,

        /// <remarks/>
        [EnumMember(Value = "04.08")]
        [XmlEnum("04.08")]
        Item0408,

        /// <remarks/>
        [EnumMember(Value = "04.09")]
        [XmlEnum("04.09")]
        Item0409,

        /// <remarks/>
        [EnumMember(Value = "04.10")]
        [XmlEnum("04.10")]
        Item0410,

        /// <remarks/>
        [EnumMember(Value = "04.11")]
        [XmlEnum("04.11")]
        Item0411,

        /// <remarks/>
        [EnumMember(Value = "04.12")]
        [XmlEnum("04.12")]
        Item0412,

        /// <remarks/>
        [EnumMember(Value = "04.13")]
        [XmlEnum("04.13")]
        Item0413,

        /// <remarks/>
        [EnumMember(Value = "04.14")]
        [XmlEnum("04.14")]
        Item0414,

        /// <remarks/>
        [EnumMember(Value = "04.15")]
        [XmlEnum("04.15")]
        Item0415,

        /// <remarks/>
        [EnumMember(Value = "04.16")]
        [XmlEnum("04.16")]
        Item0416,

        /// <remarks/>
        [EnumMember(Value = "04.17")]
        [XmlEnum("04.17")]
        Item0417,

        /// <remarks/>
        [EnumMember(Value = "04.18")]
        [XmlEnum("04.18")]
        Item0418,

        /// <remarks/>
        [EnumMember(Value = "04.19")]
        [XmlEnum("04.19")]
        Item0419,

        /// <remarks/>
        [EnumMember(Value = "04.20")]
        [XmlEnum("04.20")]
        Item0420,

        /// <remarks/>
        [EnumMember(Value = "04.21")]
        [XmlEnum("04.21")]
        Item0421,

        /// <remarks/>
        [EnumMember(Value = "04.22")]
        [XmlEnum("04.22")]
        Item0422,

        /// <remarks/>
        [EnumMember(Value = "04.23")]
        [XmlEnum("04.23")]
        Item0423,

        /// <remarks/>
        [EnumMember(Value = "05.01")]
        [XmlEnum("05.01")]
        Item0501,

        /// <remarks/>
        [EnumMember(Value = "05.02")]
        [XmlEnum("05.02")]
        Item0502,

        /// <remarks/>
        [EnumMember(Value = "05.03")]
        [XmlEnum("05.03")]
        Item0503,

        /// <remarks/>
        [EnumMember(Value = "05.04")]
        [XmlEnum("05.04")]
        Item0504,

        /// <remarks/>
        [EnumMember(Value = "05.05")]
        [XmlEnum("05.05")]
        Item0505,

        /// <remarks/>
        [EnumMember(Value = "05.06")]
        [XmlEnum("05.06")]
        Item0506,

        /// <remarks/>
        [EnumMember(Value = "05.07")]
        [XmlEnum("05.07")]
        Item0507,

        /// <remarks/>
        [EnumMember(Value = "05.08")]
        [XmlEnum("05.08")]
        Item0508,

        /// <remarks/>
        [EnumMember(Value = "05.09")]
        [XmlEnum("05.09")]
        Item0509,

        /// <remarks/>
        [EnumMember(Value = "06.01")]
        [XmlEnum("06.01")]
        Item0601,

        /// <remarks/>
        [EnumMember(Value = "06.02")]
        [XmlEnum("06.02")]
        Item0602,

        /// <remarks/>
        [EnumMember(Value = "06.03")]
        [XmlEnum("06.03")]
        Item0603,

        /// <remarks/>
        [EnumMember(Value = "06.04")]
        [XmlEnum("06.04")]
        Item0604,

        /// <remarks/>
        [EnumMember(Value = "06.05")]
        [XmlEnum("06.05")]
        Item0605,

        /// <remarks/>
        [EnumMember(Value = "06.06")]
        [XmlEnum("06.06")]
        Item0606,

        /// <remarks/>
        [EnumMember(Value = "07.01")]
        [XmlEnum("07.01")]
        Item0701,

        /// <remarks/>
        [EnumMember(Value = "07.02")]
        [XmlEnum("07.02")]
        Item0702,

        /// <remarks/>
        [EnumMember(Value = "07.03")]
        [XmlEnum("07.03")]
        Item0703,

        /// <remarks/>
        [EnumMember(Value = "07.04")]
        [XmlEnum("07.04")]
        Item0704,

        /// <remarks/>
        [EnumMember(Value = "07.05")]
        [XmlEnum("07.05")]
        Item0705,

        /// <remarks/>
        [EnumMember(Value = "07.06")]
        [XmlEnum("07.06")]
        Item0706,

        /// <remarks/>
        [EnumMember(Value = "07.07")]
        [XmlEnum("07.07")]
        Item0707,

        /// <remarks/>
        [EnumMember(Value = "07.08")]
        [XmlEnum("07.08")]
        Item0708,

        /// <remarks/>
        [EnumMember(Value = "07.09")]
        [XmlEnum("07.09")]
        Item0709,

        /// <remarks/>
        [EnumMember(Value = "07.10")]
        [XmlEnum("07.10")]
        Item0710,

        /// <remarks/>
        [EnumMember(Value = "07.11")]
        [XmlEnum("07.11")]
        Item0711,

        /// <remarks/>
        [EnumMember(Value = "07.12")]
        [XmlEnum("07.12")]
        Item0712,

        /// <remarks/>
        [EnumMember(Value = "07.13")]
        [XmlEnum("07.13")]
        Item0713,

        /// <remarks/>
        [EnumMember(Value = "07.16")]
        [XmlEnum("07.16")]
        Item0716,

        /// <remarks/>
        [EnumMember(Value = "07.17")]
        [XmlEnum("07.17")]
        Item0717,

        /// <remarks/>
        [EnumMember(Value = "07.18")]
        [XmlEnum("07.18")]
        Item0718,

        /// <remarks/>
        [EnumMember(Value = "07.19")]
        [XmlEnum("07.19")]
        Item0719,

        /// <remarks/>
        [EnumMember(Value = "07.20")]
        [XmlEnum("07.20")]
        Item0720,

        /// <remarks/>
        [EnumMember(Value = "07.21")]
        [XmlEnum("07.21")]
        Item0721,

        /// <remarks/>
        [EnumMember(Value = "07.22")]
        [XmlEnum("07.22")]
        Item0722,

        /// <remarks/>
        [EnumMember(Value = "08.01")]
        [XmlEnum("08.01")]
        Item0801,

        /// <remarks/>
        [EnumMember(Value = "08.02")]
        [XmlEnum("08.02")]
        Item0802,

        /// <remarks/>
        [EnumMember(Value = "09.01")]
        [XmlEnum("09.01")]
        Item0901,

        /// <remarks/>
        [EnumMember(Value = "09.02")]
        [XmlEnum("09.02")]
        Item0902,

        /// <remarks/>
        [EnumMember(Value = "09.03")]
        [XmlEnum("09.03")]
        Item0903,

        /// <remarks/>
        [EnumMember(Value = "10.01")]
        [XmlEnum("10.01")]
        Item1001,

        /// <remarks/>
        [EnumMember(Value = "10.02")]
        [XmlEnum("10.02")]
        Item1002,

        /// <remarks/>
        [EnumMember(Value = "10.03")]
        [XmlEnum("10.03")]
        Item1003,

        /// <remarks/>
        [EnumMember(Value = "10.04")]
        [XmlEnum("10.04")]
        Item1004,

        /// <remarks/>
        [EnumMember(Value = "10.05")]
        [XmlEnum("10.05")]
        Item1005,

        /// <remarks/>
        [EnumMember(Value = "10.06")]
        [XmlEnum("10.06")]
        Item1006,

        /// <remarks/>
        [EnumMember(Value = "10.07")]
        [XmlEnum("10.07")]
        Item1007,

        /// <remarks/>
        [EnumMember(Value = "10.08")]
        [XmlEnum("10.08")]
        Item1008,

        /// <remarks/>
        [EnumMember(Value = "10.09")]
        [XmlEnum("10.09")]
        Item1009,

        /// <remarks/>
        [EnumMember(Value = "10.10")]
        [XmlEnum("10.10")]
        Item1010,

        /// <remarks/>
        [EnumMember(Value = "11.01")]
        [XmlEnum("11.01")]
        Item1101,

        /// <remarks/>
        [EnumMember(Value = "11.02")]
        [XmlEnum("11.02")]
        Item1102,

        /// <remarks/>
        [EnumMember(Value = "11.03")]
        [XmlEnum("11.03")]
        Item1103,

        /// <remarks/>
        [EnumMember(Value = "11.04")]
        [XmlEnum("11.04")]
        Item1104,

        /// <remarks/>
        [EnumMember(Value = "12.01")]
        [XmlEnum("12.01")]
        Item1201,

        /// <remarks/>
        [EnumMember(Value = "12.02")]
        [XmlEnum("12.02")]
        Item1202,

        /// <remarks/>
        [EnumMember(Value = "12.03")]
        [XmlEnum("12.03")]
        Item1203,

        /// <remarks/>
        [EnumMember(Value = "12.04")]
        [XmlEnum("12.04")]
        Item1204,

        /// <remarks/>
        [EnumMember(Value = "12.05")]
        [XmlEnum("12.05")]
        Item1205,

        /// <remarks/>
        [EnumMember(Value = "12.06")]
        [XmlEnum("12.06")]
        Item1206,

        /// <remarks/>
        [EnumMember(Value = "12.07")]
        [XmlEnum("12.07")]
        Item1207,

        /// <remarks/>
        [EnumMember(Value = "12.08")]
        [XmlEnum("12.08")]
        Item1208,

        /// <remarks/>
        [EnumMember(Value = "12.09")]
        [XmlEnum("12.09")]
        Item1209,

        /// <remarks/>
        [EnumMember(Value = "12.10")]
        [XmlEnum("12.10")]
        Item1210,

        /// <remarks/>
        [EnumMember(Value = "12.11")]
        [XmlEnum("12.11")]
        Item1211,

        /// <remarks/>
        [EnumMember(Value = "12.12")]
        [XmlEnum("12.12")]
        Item1212,

        /// <remarks/>
        [EnumMember(Value = "12.13")]
        [XmlEnum("12.13")]
        Item1213,

        /// <remarks/>
        [EnumMember(Value = "12.14")]
        [XmlEnum("12.14")]
        Item1214,

        /// <remarks/>
        [EnumMember(Value = "12.15")]
        [XmlEnum("12.15")]
        Item1215,

        /// <remarks/>
        [EnumMember(Value = "12.16")]
        [XmlEnum("12.16")]
        Item1216,

        /// <remarks/>
        [EnumMember(Value = "12.17")]
        [XmlEnum("12.17")]
        Item1217,

        /// <remarks/>
        [EnumMember(Value = "13.02")]
        [XmlEnum("13.02")]
        Item1302,

        /// <remarks/>
        [EnumMember(Value = "13.03")]
        [XmlEnum("13.03")]
        Item1303,

        /// <remarks/>
        [EnumMember(Value = "13.04")]
        [XmlEnum("13.04")]
        Item1304,

        /// <remarks/>
        [EnumMember(Value = "13.05")]
        [XmlEnum("13.05")]
        Item1305,

        /// <remarks/>
        [EnumMember(Value = "14.01")]
        [XmlEnum("14.01")]
        Item1401,

        /// <remarks/>
        [EnumMember(Value = "14.02")]
        [XmlEnum("14.02")]
        Item1402,

        /// <remarks/>
        [EnumMember(Value = "14.03")]
        [XmlEnum("14.03")]
        Item1403,

        /// <remarks/>
        [EnumMember(Value = "14.04")]
        [XmlEnum("14.04")]
        Item1404,

        /// <remarks/>
        [EnumMember(Value = "14.05")]
        [XmlEnum("14.05")]
        Item1405,

        /// <remarks/>
        [EnumMember(Value = "14.06")]
        [XmlEnum("14.06")]
        Item1406,

        /// <remarks/>
        [EnumMember(Value = "14.07")]
        [XmlEnum("14.07")]
        Item1407,

        /// <remarks/>
        [EnumMember(Value = "14.08")]
        [XmlEnum("14.08")]
        Item1408,

        /// <remarks/>
        [EnumMember(Value = "14.09")]
        [XmlEnum("14.09")]
        Item1409,

        /// <remarks/>
        [EnumMember(Value = "14.10")]
        [XmlEnum("14.10")]
        Item1410,

        /// <remarks/>
        [EnumMember(Value = "14.11")]
        [XmlEnum("14.11")]
        Item1411,

        /// <remarks/>
        [EnumMember(Value = "14.12")]
        [XmlEnum("14.12")]
        Item1412,

        /// <remarks/>
        [EnumMember(Value = "14.13")]
        [XmlEnum("14.13")]
        Item1413,

        /// <remarks/>
        [EnumMember(Value = "14.14")]
        [XmlEnum("14.14")]
        Item1414,

        /// <remarks/>
        [EnumMember(Value = "15.01")]
        [XmlEnum("15.01")]
        Item1501,

        /// <remarks/>
        [EnumMember(Value = "15.02")]
        [XmlEnum("15.02")]
        Item1502,

        /// <remarks/>
        [EnumMember(Value = "15.03")]
        [XmlEnum("15.03")]
        Item1503,

        /// <remarks/>
        [EnumMember(Value = "15.04")]
        [XmlEnum("15.04")]
        Item1504,

        /// <remarks/>
        [EnumMember(Value = "15.05")]
        [XmlEnum("15.05")]
        Item1505,

        /// <remarks/>
        [EnumMember(Value = "15.06")]
        [XmlEnum("15.06")]
        Item1506,

        /// <remarks/>
        [EnumMember(Value = "15.07")]
        [XmlEnum("15.07")]
        Item1507,

        /// <remarks/>
        [EnumMember(Value = "15.08")]
        [XmlEnum("15.08")]
        Item1508,

        /// <remarks/>
        [EnumMember(Value = "15.09")]
        [XmlEnum("15.09")]
        Item1509,

        /// <remarks/>
        [EnumMember(Value = "15.10")]
        [XmlEnum("15.10")]
        Item1510,

        /// <remarks/>
        [EnumMember(Value = "15.11")]
        [XmlEnum("15.11")]
        Item1511,

        /// <remarks/>
        [EnumMember(Value = "15.12")]
        [XmlEnum("15.12")]
        Item1512,

        /// <remarks/>
        [EnumMember(Value = "15.13")]
        [XmlEnum("15.13")]
        Item1513,

        /// <remarks/>
        [EnumMember(Value = "15.14")]
        [XmlEnum("15.14")]
        Item1514,

        /// <remarks/>
        [EnumMember(Value = "15.15")]
        [XmlEnum("15.15")]
        Item1515,

        /// <remarks/>
        [EnumMember(Value = "15.16")]
        [XmlEnum("15.16")]
        Item1516,

        /// <remarks/>
        [EnumMember(Value = "15.17")]
        [XmlEnum("15.17")]
        Item1517,

        /// <remarks/>
        [EnumMember(Value = "15.18")]
        [XmlEnum("15.18")]
        Item1518,

        /// <remarks/>
        [EnumMember(Value = "16.01")]
        [XmlEnum("16.01")]
        Item1601,

        /// <remarks/>
        [EnumMember(Value = "16.02")]
        [XmlEnum("16.02")]
        Item1602,

        /// <remarks/>
        [EnumMember(Value = "17.01")]
        [XmlEnum("17.01")]
        Item1701,

        /// <remarks/>
        [EnumMember(Value = "17.02")]
        [XmlEnum("17.02")]
        Item1702,

        /// <remarks/>
        [EnumMember(Value = "17.03")]
        [XmlEnum("17.03")]
        Item1703,

        /// <remarks/>
        [EnumMember(Value = "17.04")]
        [XmlEnum("17.04")]
        Item1704,

        /// <remarks/>
        [EnumMember(Value = "17.05")]
        [XmlEnum("17.05")]
        Item1705,

        /// <remarks/>
        [EnumMember(Value = "17.06")]
        [XmlEnum("17.06")]
        Item1706,

        /// <remarks/>
        [EnumMember(Value = "17.08")]
        [XmlEnum("17.08")]
        Item1708,

        /// <remarks/>
        [EnumMember(Value = "17.09")]
        [XmlEnum("17.09")]
        Item1709,

        /// <remarks/>
        [EnumMember(Value = "17.10")]
        [XmlEnum("17.10")]
        Item1710,

        /// <remarks/>
        [EnumMember(Value = "17.11")]
        [XmlEnum("17.11")]
        Item1711,

        /// <remarks/>
        [EnumMember(Value = "17.12")]
        [XmlEnum("17.12")]
        Item1712,

        /// <remarks/>
        [EnumMember(Value = "17.13")]
        [XmlEnum("17.13")]
        Item1713,

        /// <remarks/>
        [EnumMember(Value = "17.14")]
        [XmlEnum("17.14")]
        Item1714,

        /// <remarks/>
        [EnumMember(Value = "17.15")]
        [XmlEnum("17.15")]
        Item1715,

        /// <remarks/>
        [EnumMember(Value = "17.16")]
        [XmlEnum("17.16")]
        Item1716,

        /// <remarks/>
        [EnumMember(Value = "17.17")]
        [XmlEnum("17.17")]
        Item1717,

        /// <remarks/>
        [EnumMember(Value = "17.18")]
        [XmlEnum("17.18")]
        Item1718,

        /// <remarks/>
        [EnumMember(Value = "17.19")]
        [XmlEnum("17.19")]
        Item1719,

        /// <remarks/>
        [EnumMember(Value = "17.20")]
        [XmlEnum("17.20")]
        Item1720,

        /// <remarks/>
        [EnumMember(Value = "17.21")]
        [XmlEnum("17.21")]
        Item1721,

        /// <remarks/>
        [EnumMember(Value = "17.22")]
        [XmlEnum("17.22")]
        Item1722,

        /// <remarks/>
        [EnumMember(Value = "17.23")]
        [XmlEnum("17.23")]
        Item1723,

        /// <remarks/>
        [EnumMember(Value = "17.24")]
        [XmlEnum("17.24")]
        Item1724,

        /// <remarks/>
        [EnumMember(Value = "17.25")]
        [XmlEnum("17.25")]
        Item1725,

        /// <remarks/>
        [EnumMember(Value = "18.01")]
        [XmlEnum("18.01")]
        Item1801,

        /// <remarks/>
        [EnumMember(Value = "19.01")]
        [XmlEnum("19.01")]
        Item1901,

        /// <remarks/>
        [EnumMember(Value = "20.01")]
        [XmlEnum("20.01")]
        Item2001,

        /// <remarks/>
        [EnumMember(Value = "20.02")]
        [XmlEnum("20.02")]
        Item2002,

        /// <remarks/>
        [EnumMember(Value = "20.03")]
        [XmlEnum("20.03")]
        Item2003,

        /// <remarks/>
        [EnumMember(Value = "21.01")]
        [XmlEnum("21.01")]
        Item2101,

        /// <remarks/>
        [EnumMember(Value = "22.01")]
        [XmlEnum("22.01")]
        Item2201,

        /// <remarks/>
        [EnumMember(Value = "23.01")]
        [XmlEnum("23.01")]
        Item2301,

        /// <remarks/>
        [EnumMember(Value = "24.01")]
        [XmlEnum("24.01")]
        Item2401,

        /// <remarks/>
        [EnumMember(Value = "25.01")]
        [XmlEnum("25.01")]
        Item2501,

        /// <remarks/>
        [EnumMember(Value = "25.02")]
        [XmlEnum("25.02")]
        Item2502,

        /// <remarks/>
        [EnumMember(Value = "25.03")]
        [XmlEnum("25.03")]
        Item2503,

        /// <remarks/>
        [EnumMember(Value = "25.04")]
        [XmlEnum("25.04")]
        Item2504,

        /// <remarks/>
        [EnumMember(Value = "25.05")]
        [XmlEnum("25.05")]
        Item2505,

        /// <remarks/>
        [EnumMember(Value = "26.01")]
        [XmlEnum("26.01")]
        Item2601,

        /// <remarks/>
        [EnumMember(Value = "27.01")]
        [XmlEnum("27.01")]
        Item2701,

        /// <remarks/>
        [EnumMember(Value = "28.01")]
        [XmlEnum("28.01")]
        Item2801,

        /// <remarks/>
        [EnumMember(Value = "29.01")]
        [XmlEnum("29.01")]
        Item2901,

        /// <remarks/>
        [EnumMember(Value = "30.01")]
        [XmlEnum("30.01")]
        Item3001,

        /// <remarks/>
        [EnumMember(Value = "31.01")]
        [XmlEnum("31.01")]
        Item3101,

        /// <remarks/>
        [EnumMember(Value = "32.01")]
        [XmlEnum("32.01")]
        Item3201,

        /// <remarks/>
        [EnumMember(Value = "33.01")]
        [XmlEnum("33.01")]
        Item3301,

        /// <remarks/>
        [EnumMember(Value = "34.01")]
        [XmlEnum("34.01")]
        Item3401,

        /// <remarks/>
        [EnumMember(Value = "35.01")]
        [XmlEnum("35.01")]
        Item3501,

        /// <remarks/>
        [EnumMember(Value = "36.01")]
        [XmlEnum("36.01")]
        Item3601,

        /// <remarks/>
        [EnumMember(Value = "37.01")]
        [XmlEnum("37.01")]
        Item3701,

        /// <remarks/>
        [EnumMember(Value = "38.01")]
        [XmlEnum("38.01")]
        Item3801,

        /// <remarks/>
        [EnumMember(Value = "39.01")]
        [XmlEnum("39.01")]
        Item3901,

        /// <remarks/>
        [EnumMember(Value = "40.01")]
        [XmlEnum("40.01")]
        Item4001,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndISS
    {
        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Exigivel,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        NaoIcidencia,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Isencao,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Exportacao,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Imunidade,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ExigibilidadeSuspensaDecisaoJudicial,

        /// <remarks/>
        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        ExigibilidadeSuspensaProcessoAdministrativo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
    {
        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Sim,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Nao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPIS
    {
        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISAliq PISAliq { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISNT PISNT { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISOutr PISOutr { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISQtde PISQtde { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoPISPISAliqCST CST { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pPIS { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {
        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        CST01,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        CST02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISNT
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoPISPISNTCST CST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {
        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        CST04,

        /// <remarks/>
        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        CST05,

        /// <remarks/>
        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        CST06,

        /// <remarks/>
        [EnumMember(Value = "07")]
        [XmlEnum("07")]
        CST07,

        /// <remarks/>
        [EnumMember(Value = "08")]
        [XmlEnum("08")]
        CST08,

        /// <remarks/>
        [EnumMember(Value = "09")]
        [XmlEnum("09")]
        CST09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoPISPISOutrCST CST { get; set; }

        /// <remarks/>
        public string pPIS { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {
        /// <remarks/>
        [EnumMember(Value = "49")]
        [XmlEnum("49")]
        CST49,

        /// <remarks/>
        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        CST50,

        /// <remarks/>
        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        CST51,

        /// <remarks/>
        [EnumMember(Value = "52")]
        [XmlEnum("52")]
        CST52,

        /// <remarks/>
        [EnumMember(Value = "53")]
        [XmlEnum("53")]
        CST53,

        /// <remarks/>
        [EnumMember(Value = "54")]
        [XmlEnum("54")]
        CST54,

        /// <remarks/>
        [EnumMember(Value = "55")]
        [XmlEnum("55")]
        CST55,

        /// <remarks/>
        [EnumMember(Value = "56")]
        [XmlEnum("56")]
        CST56,

        /// <remarks/>
        [EnumMember(Value = "60")]
        [XmlEnum("60")]
        CST60,

        /// <remarks/>
        [EnumMember(Value = "61")]
        [XmlEnum("61")]
        CST61,

        /// <remarks/>
        [EnumMember(Value = "62")]
        [XmlEnum("62")]
        CST62,

        /// <remarks/>
        [EnumMember(Value = "63")]
        [XmlEnum("63")]
        CST63,

        /// <remarks/>
        [EnumMember(Value = "64")]
        [XmlEnum("64")]
        CST64,

        /// <remarks/>
        [EnumMember(Value = "65")]
        [XmlEnum("65")]
        CST65,

        /// <remarks/>
        [EnumMember(Value = "66")]
        [XmlEnum("66")]
        CST66,

        /// <remarks/>
        [EnumMember(Value = "67")]
        [XmlEnum("67")]
        CST67,

        /// <remarks/>
        [EnumMember(Value = "70")]
        [XmlEnum("70")]
        CST70,

        /// <remarks/>
        [EnumMember(Value = "71")]
        [XmlEnum("71")]
        CST71,

        /// <remarks/>
        [EnumMember(Value = "72")]
        [XmlEnum("72")]
        CST72,

        /// <remarks/>
        [EnumMember(Value = "73")]
        [XmlEnum("73")]
        CST73,

        /// <remarks/>
        [EnumMember(Value = "74")]
        [XmlEnum("74")]
        CST74,

        /// <remarks/>
        [EnumMember(Value = "75")]
        [XmlEnum("75")]
        CST75,

        /// <remarks/>
        [EnumMember(Value = "98")]
        [XmlEnum("98")]
        CST98,

        /// <remarks/>
        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        CST99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoPISPISQtdeCST CST { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {
        /// <remarks/>
        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        CST03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISST
    {
        /// <remarks/>
        public string pPIS { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>    
        public string vAliqProd { get; set; }

        /// <remarks/>    
        public string vBC { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINS
    {
        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutr COFINSOutr { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtde COFINSQtde { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string pCOFINS { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {
        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        CST01,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        CST02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {
        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        CST04,

        /// <remarks/>
        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        CST05,

        /// <remarks/>
        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        CST06,

        /// <remarks/>
        [EnumMember(Value = "07")]
        [XmlEnum("07")]
        CST07,

        /// <remarks/>
        [EnumMember(Value = "08")]
        [XmlEnum("08")]
        CST08,

        /// <remarks/>
        [EnumMember(Value = "09")]
        [XmlEnum("09")]
        CST09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST { get; set; }

        /// <remarks/>
        public string pCOFINS { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {
        /// <remarks/>
        [EnumMember(Value = "49")]
        [XmlEnum("49")]
        CST49,

        /// <remarks/>
        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        CST50,

        /// <remarks/>
        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        CST51,

        /// <remarks/>
        [EnumMember(Value = "52")]
        [XmlEnum("52")]
        CST52,

        /// <remarks/>
        [EnumMember(Value = "53")]
        [XmlEnum("53")]
        CST53,

        /// <remarks/>
        [EnumMember(Value = "54")]
        [XmlEnum("54")]
        CST54,

        /// <remarks/>
        [EnumMember(Value = "55")]
        [XmlEnum("55")]
        CST55,

        /// <remarks/>
        [EnumMember(Value = "56")]
        [XmlEnum("56")]
        CST56,

        /// <remarks/>
        [EnumMember(Value = "60")]
        [XmlEnum("60")]
        CST60,

        /// <remarks/>
        [EnumMember(Value = "61")]
        [XmlEnum("61")]
        CST61,

        /// <remarks/>
        [EnumMember(Value = "62")]
        [XmlEnum("62")]
        CST62,

        /// <remarks/>
        [EnumMember(Value = "63")]
        [XmlEnum("63")]
        CST63,

        /// <remarks/>
        [EnumMember(Value = "64")]
        [XmlEnum("64")]
        CST64,

        /// <remarks/>
        [EnumMember(Value = "65")]
        [XmlEnum("65")]
        CST65,

        /// <remarks/>
        [EnumMember(Value = "66")]
        [XmlEnum("66")]
        CST66,

        /// <remarks/>
        [EnumMember(Value = "67")]
        [XmlEnum("67")]
        CST67,

        /// <remarks/>
        [EnumMember(Value = "70")]
        [XmlEnum("70")]
        CST70,

        /// <remarks/>
        [EnumMember(Value = "71")]
        [XmlEnum("71")]
        CST71,

        /// <remarks/>
        [EnumMember(Value = "72")]
        [XmlEnum("72")]
        CST72,

        /// <remarks/>
        [EnumMember(Value = "73")]
        [XmlEnum("73")]
        CST73,

        /// <remarks/>
        [EnumMember(Value = "74")]
        [XmlEnum("74")]
        CST74,

        /// <remarks/>
        [EnumMember(Value = "75")]
        [XmlEnum("75")]
        CST75,

        /// <remarks/>
        [EnumMember(Value = "98")]
        [XmlEnum("98")]
        CST98,

        /// <remarks/>
        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        CST99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {
        /// <remarks/>
        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        CST03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSST
    {
        /// <remarks/>
        public string pCOFINS { get; set; }

        /// <remarks/>
        public string qBCProd { get; set; }

        /// <remarks/>
        public string vAliqProd { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSUFDest
    {
        /// <remarks/>
        public string vBCUFDest { get; set; }

        /// <remarks/>
        public string vBCFCPUFDest { get; set; }

        /// <remarks/>
        public string pFCPUFDest { get; set; }

        /// <remarks/>
        public string pICMSUFDest { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInter { get; set; }

        /// <remarks/>
        public string pICMSInterPart { get; set; }

        /// <remarks/>
        public string vFCPUFDest { get; set; }

        /// <remarks/>
        public string vICMSUFDest { get; set; }

        /// <remarks/>
        public string vICMSUFRemet { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter
    {
        /// <remarks/>
        [EnumMember(Value = "4.00")]
        [XmlEnum("4.00")]
        AliqInterestadualProducaoImportados,

        /// <remarks/>
        [EnumMember(Value = "7.00")]
        [XmlEnum("7.00")]
        SulESudelteParaOutrasRegioes,

        /// <remarks/>
        [EnumMember(Value = "12.00")]
        [XmlEnum("12.00")]
        DemaisCasos,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevol
    {
        /// <remarks/>
        public string pDevol { get; set; }

        /// <remarks/>
        public TNFeInfNFeDetImpostoDevolIPI IPI { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevolIPI
    {
        /// <remarks/>
        public string vIPIDevol { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal
    {
        /// <remarks/>
        public TNFeInfNFeTotalICMSTot ICMSTot { get; set; }

        /// <remarks/>
        public TNFeInfNFeTotalISSQNtot ISSQNtot { get; set; }

        /// <remarks/>
        public TNFeInfNFeTotalRetTrib retTrib { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {
        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vICMS { get; set; }

        /// <remarks/>
        public string vICMSDeson { get; set; }

        /// <remarks/>
        public string vFCPUFDest { get; set; }

        /// <remarks/>
        public string vICMSUFDest { get; set; }

        /// <remarks/>
        public string vICMSUFRemet { get; set; }

        /// <remarks/>
        public string vFCP { get; set; }

        /// <remarks/>
        public string vBCST { get; set; }

        /// <remarks/>
        public string vST { get; set; }

        /// <remarks/>
        public string vFCPST { get; set; }

        /// <remarks/>
        public string vFCPSTRet { get; set; }

        /// <remarks/>
        public string vProd { get; set; }

        /// <remarks/>
        public string vFrete { get; set; }

        /// <remarks/>
        public string vSeg { get; set; }

        /// <remarks/>
        public string vDesc { get; set; }

        /// <remarks/>
        public string vII { get; set; }

        /// <remarks/>
        public string vIPI { get; set; }

        /// <remarks/>
        public string vIPIDevol { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }

        /// <remarks/>
        public string vOutro { get; set; }

        /// <remarks/>
        public string vNF { get; set; }

        /// <remarks/>
        public string vTotTrib { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot
    {
        /// <remarks/>
        public string vServ { get; set; }

        /// <remarks/>
        public string vBC { get; set; }

        /// <remarks/>
        public string vISS { get; set; }

        /// <remarks/>
        public string vPIS { get; set; }

        /// <remarks/>
        public string vCOFINS { get; set; }

        /// <remarks/>
        public string dCompet { get; set; }

        /// <remarks/>
        public string vDeducao { get; set; }

        /// <remarks/>
        public string vOutro { get; set; }

        /// <remarks/>
        public string vDescIncond { get; set; }

        /// <remarks/>
        public string vDescCond { get; set; }

        /// <remarks/>
        public string vISSRet { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool cRegTribSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTotalISSQNtotCRegTrib
    {
        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        MicroempresaMunicipal,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Estimativa,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        SociedadeProfissionais,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Cooperativa,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        MEI,

        /// <remarks/>
        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        ME_EPP,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalRetTrib
    {
        /// <remarks/>
        public string vRetPIS { get; set; }

        /// <remarks/>
        public string vRetCOFINS { get; set; }

        /// <remarks/>
        public string vRetCSLL { get; set; }

        /// <remarks/>
        public string vBCIRRF { get; set; }

        /// <remarks/>
        public string vIRRF { get; set; }

        /// <remarks/>
        public string vBCRetPrev { get; set; }

        /// <remarks/>
        public string vRetPrev { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTransp
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeTranspModFrete modFrete { get; set; }

        /// <remarks/>
        public TNFeInfNFeTranspTransporta transporta { get; set; }

        /// <remarks/>
        public TNFeInfNFeTranspRetTransp retTransp { get; set; }

        /// <remarks/>
        public string balsa { get; set; }

        /// <remarks/>
        public TVeiculo reboque { get; set; }

        /// <remarks/>
        public string vagao { get; set; }

        /// <remarks/>
        public TVeiculo veicTransp { get; set; }

        /// <remarks/>
        [XmlElement("vol")]
        public List<TNFeInfNFeTranspVol> vol { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        ContracaoFreteRemetente,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ContracaoFreteDestinatario,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ContracaoFreteTerceiros,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        TraspProprioRemetente,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        TraspProprioDestinatario,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        SemTransporte,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta
    {
        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        public string CPF { get; set; }

        /// <remarks/>
        public string xNome { get; set; }

        /// <remarks/>
        public string IE { get; set; }

        /// <remarks/>
        public string xEnder { get; set; }

        /// <remarks/>
        public string xMun { get; set; }

        /// <remarks/>
        public TUf UF { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool UFSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspRetTransp
    {
        /// <remarks/>
        public string vServ { get; set; }

        /// <remarks/>
        public string vBCRet { get; set; }

        /// <remarks/>
        public string pICMSRet { get; set; }

        /// <remarks/>
        public string vICMSRet { get; set; }

        /// <remarks/>
        public string CFOP { get; set; }

        /// <remarks/>
        public string cMunFG { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TVeiculo
    {
        /// <remarks/>
        public string placa { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UF { get; set; }

        /// <remarks/>
        public string RNTC { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol
    {
        /// <remarks/>
        public string qVol { get; set; }

        /// <remarks/>
        public string esp { get; set; }

        /// <remarks/>
        public string marca { get; set; }

        /// <remarks/>
        public string nVol { get; set; }

        /// <remarks/>
        public string pesoL { get; set; }

        /// <remarks/>
        public string pesoB { get; set; }

        /// <remarks/>
        [XmlElement("lacres")]
        public List<TNFeInfNFeTranspVolLacres> lacres { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVolLacres
    {
        /// <remarks/>
        public string nLacre { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr
    {
        /// <remarks/>
        public TNFeInfNFeCobrFat fat { get; set; }

        /// <remarks/>
        [XmlElement("dup")]
        public List<TNFeInfNFeCobrDup> dup { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrFat
    {
        /// <remarks/>
        public string nFat { get; set; }

        /// <remarks/>
        public string vOrig { get; set; }

        /// <remarks/>
        public string vDesc { get; set; }

        /// <remarks/>
        public string vLiq { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrDup
    {
        /// <remarks/>
        public string nDup { get; set; }

        /// <remarks/>
        public string dVenc { get; set; }

        /// <remarks/>
        public string vDup { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePag
    {
        /// <remarks/>
        [XmlElement("detPag")]
        public List<TNFeInfNFePagDetPag> detPag { get; set; }

        /// <remarks/>
        public string vTroco { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagDetPag
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFePagDetPagIndPag indPag { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool indPagSpecified { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFePagDetPagTPag tPag { get; set; }

        /// <remarks/>
        public string vPag { get; set; }

        /// <remarks/>
        public TNFeInfNFePagDetPagCard card { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagDetPagIndPag
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        PagamanetoAVista,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        PagamentoAPrazo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagDetPagTPag
    {
        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Dinheiro,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Cheque,

        /// <remarks/>
        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        CartaoCredito,

        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        CartaoDebito,

        /// <remarks/>
        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        CreditoLoja,

        /// <remarks/>
        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        ValeAlimentacao,

        /// <remarks/>
        [EnumMember(Value = "11")]
        [XmlEnum("11")]
        ValeRefeicao,

        /// <remarks/>
        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        ValePresente,

        /// <remarks/>
        [EnumMember(Value = "13")]
        [XmlEnum("13")]
        ValeCombustivel,

        /// <remarks/>
        //[EnumMember(Value = "14")]
        //[System.Xml.Serialization.XmlEnumAttribute("14")]
        //BoletoBancario,

        /// <remarks/>
        [EnumMember(Value = "15")]
        [XmlEnum("15")]
        BoletoBancario,

        /// <remarks/>
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        SemPagamento,

        /// <remarks/>
        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagDetPagCard
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFePagDetPagCardTpIntegra tpIntegra { get; set; }

        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFePagDetPagCardTBand tBand { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        [JsonIgnore()]
        public bool tBandSpecified { get; set; }

        /// <remarks/>
        public string cAut { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagDetPagCardTpIntegra
    {
        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagDetPagCardTBand
    {

        /// <remarks/>
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [EnumMember(Value = "07")]
        [XmlEnum("07")]
        Item07,

        /// <remarks/>
        [EnumMember(Value = "08")]
        [XmlEnum("08")]
        Item08,

        /// <remarks/>
        [EnumMember(Value = "09")]
        [XmlEnum("09")]
        Item09,

        /// <remarks/>
        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic
    {
        /// <remarks/>
        public string infAdFisco { get; set; }

        /// <remarks/>
        public string infCpl { get; set; }

        /// <remarks/>
        [XmlElement("obsCont")]
        public List<TNFeInfNFeInfAdicObsCont> obsCont { get; set; }

        /// <remarks/>
        [XmlElement("obsFisco")]
        public List<TNFeInfNFeInfAdicObsFisco> obsFisco { get; set; }

        /// <remarks/>
        [XmlElement("procRef")]
        public List<TNFeInfNFeInfAdicProcRef> procRef { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsCont
    {
        /// <remarks/>
        public string xTexto { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string xCampo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsFisco
    {
        /// <remarks/>
        public string xTexto { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string xCampo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef
    {
        /// <remarks/>
        public string nProc { get; set; }

        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TNFeInfNFeInfAdicProcRefIndProc indProc { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {
        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        SEFAZ,

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        JusticaFederal,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        JusticaEstadual,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Secex_RFB,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Outros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta
    {
        /// <remarks/>
        [JsonConverter(typeof(StringEnumConverter))]
        public TUfEmi UFSaidaPais { get; set; }

        /// <remarks/>
        public string xLocExporta { get; set; }

        /// <remarks/>
        public string xLocDespacho { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCompra
    {
        /// <remarks/>
        public string xNEmp { get; set; }

        /// <remarks/>
        public string xPed { get; set; }

        /// <remarks/>
        public string xCont { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana
    {
        /// <remarks/>
        public string safra { get; set; }

        /// <remarks/>
        public string @ref { get; set; }

        /// <remarks/>
        [XmlElement("forDia")]
        public List<TNFeInfNFeCanaForDia> forDia { get; set; }

        /// <remarks/>
        public string qTotMes { get; set; }

        /// <remarks/>
        public string qTotAnt { get; set; }

        /// <remarks/>
        public string qTotGer { get; set; }

        /// <remarks/>
        [XmlElement("deduc")]
        public List<TNFeInfNFeCanaDeduc> deduc { get; set; }

        /// <remarks/>
        public string vFor { get; set; }
        /// <remarks/>
        public string vTotDed { get; set; }

        /// <remarks/>
        public string vLiqFor { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaForDia
    {
        /// <remarks/>
        public string qtde { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string dia { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaDeduc
    {
        /// <remarks/>
        public string xDed { get; set; }

        /// <remarks/>
        public string vDed { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TInfRespTec
    {
        /// <remarks/>
        public string CNPJ { get; set; }

        /// <remarks/>
        public string xContato { get; set; }

        /// <remarks/>
        public string email { get; set; }

        /// <remarks/>
        public string fone { get; set; }

        /// <remarks/>
        public string idCSRT { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] hashCSRT { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeSupl
    {
        /// <remarks/>
        public string qrCode { get; set; }

        /// <remarks/>
        public string urlChave { get; set; }
    }
}