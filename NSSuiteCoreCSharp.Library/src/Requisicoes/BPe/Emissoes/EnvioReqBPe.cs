using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes.BPe.Emissoes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.src.Commons;
using NSSuiteCoreCSharp.thiss.BPe.Emissoes;
using NSSuiteCSharpLib.Requisicoes.BPe;
using NSSuiteCSharpLib.Respostas.BPe;
using NSSuiteCSharpLib.Respostas.BPe.Emissoes;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace NSSuiteCoreCSharp.src.Requisicoes.BPe.Emissoes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {
        public SignedInfoType signedInfo { get; set; }

        public SignatureValueType signatureValue { get; set; }

        public KeyInfoType keyInfo { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        public SignedInfoTypeCanonicalizationMethod canonicalizationMethod { get; set; }

        public SignedInfoTypeSignatureMethod signatureMethod { get; set; }

        public ReferenceType reference { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithm;

        public SignedInfoTypeCanonicalizationMethod()
        {
            algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
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

        public X509DataType x509Data { get; set; }
        [XmlAttribute(DataType = "ID")]
        public string id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {
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

    /// <remarks/>
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

        public string algorithm;

        public ReferenceTypeDigestMethod()
        {
            algorithm = "http://www.w3.org/2000/09/xmldsig#sha1";
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

        public string algorithm;

        public SignedInfoTypeSignatureMethod()
        {
            algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
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
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    [XmlRoot("BPe", Namespace = "http://www.portalfiscal.inf.br/bpe", IsNullable = false)]
    public partial class EnvioReqBPe : SolicitavelNaAPI, IEmissaoDFeSincrona
    {
        public TBPeInfBPe infBPe;

        public TBPeInfBPeSupl infBPeSupl;

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [JsonIgnore()]
        public SignatureType signature;

        //Metodos de Envio para API
        public IResposta Envia()
        {
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeEnvio);
            return JsonConvert.DeserializeObject<EnvioRespBPe>(resposta);
        }
        public void EnvioSincrono(TipoDownloadDFes tpDown, string caminho, bool exibirPDF, bool a3)
        {
            var envioResposta = Envia() as EnvioRespBPe;
            envioResposta.Valida();

            var consultaRequisicao = new ConsStatusProcessamentoReqBPe
            {
                CNPJ = infBPe.emit.CNPJ,
                tpAmb = (int)infBPe.ide.tpAmb,
                nsNRec = envioResposta.nsNRec
            };
            var consultaResposta = consultaRequisicao.Envia() as ConsStatusProcessamentoRespBPe;
            consultaResposta.Valida();

            var downloadRequisicao = new DownloadReqBPe
            {
                tpDown = tpDown,
                tpAmb = (int)infBPe.ide.tpAmb,
                chBPe = consultaResposta.chBPe
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadRespBPe;
            downloadResposta.ValidarESalvar(caminho, exibirPDF);

        }
        public override string ToJSONString()
        {
            JObject root = JObject.FromObject(new { BPe = this });
            return JsonConvert.SerializeObject(root, Formatting.Indented);
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPe
    {

        public TBPeInfBPeIde ide;

        public TBPeInfBPeEmit emit;

        public TBPeInfBPeComp comp;

        public TBPeInfBPeAgencia agencia;

        public TBPeInfBPeInfBPeSub infBPeSub;

        public TBPeInfBPeInfPassagem infPassagem;

        [XmlElement("infViagem")]
        public TBPeInfBPeInfViagem[] infViagem;

        public TBPeInfBPeInfValorBPe infValorBPe;

        public TBPeInfBPeImp Imp;

        [XmlElement("pag")]
        public TBPeInfBPePag[] pag;

        [XmlElement("autXML")]
        public TBPeInfBPeAutXML[] autXML;

        public TBPeInfBPeInfAdic infAdic;

        public TRespTec infRespTec;

        [XmlAttribute()]
        public string versao;

        [XmlAttribute(DataType = "ID")]
        public string Id;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeIde
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TCodUfIBGE cUF;

        [JsonConverter(typeof(StringEnumConverter))]
        public TAmb tpAmb;

        [JsonConverter(typeof(StringEnumConverter))]
        public TModBPe mod;

        public string serie;

        public string nBP;

        public string cBP;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cDV;

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeModal modal;

        public string dhEmi;

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeTpEmis tpEmis;

        public string verProc;

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeTpBPe tpBPe;

        [JsonConverter(typeof(StringEnumConverter))]
        public TIndPres indPres;

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf_sem_EX UFIni;

        public string cMunIni;

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UFFim;

        public string cMunFim;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dhCont;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xJust;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TAmb
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Producao = 1,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Homologacao = 2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TModBPe
    {

        /// <remarks/>
        [EnumMember(Value = "63")]
        [XmlEnum("63")]
        BPe,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeModal
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Rodoviario,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Aquaviario,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Ferroviario,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpEmis
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Normal,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Contingencia,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpBPe
    {

        /// <remarks/>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Normal,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Substituicao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TIndPres
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        OpPresencialNaoEmbarcado,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        OpNaoPresencialInternet,

        /// <remarks/>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        OpNaoPresencialTeleatendimento,

        /// <remarks/>
        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        EntregaADomicilio,

        /// <remarks/>
        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        OpPresenscialEmbarcada,

        /// <remarks/>
        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        OpNaoPresencialOutros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TUf_sem_EX
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
        [EnumMember(Value = "GO")]
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
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
        [EnumMember(Value = "GO")]
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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeEmit
    {

        public string CNPJ;

        public string IE;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IEST;

        public string xNome;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xFant;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IM;

        public string CNAE;

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeEmitCRT CRT;

        public TEndeEmi enderEmit;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TAR;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeEmitCRT
    {

        /// <remarks/>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        SimplesNacional,

        /// <remarks/>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        SimplesNacionalMenosRendaBruta,

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
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TEndeEmi
    {

        public string xLgr;

        public string nro;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl;

        public string xBairro;

        public string cMun;

        public string xMun;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEP;

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf_sem_EX Uf;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email;

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeComp
    {

        public string xNome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string idEstrangeiro { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IE;

        public TEndereco enderComp;


    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idEstrangeiro,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TEndereco
    {

        public string xLgr;

        public string nro;

        public string xCpl;

        public string xBairro;

        public string cMun;

        public string xMun;

        public string CEP;

        public TUf UF;

        public string cPais;

        public string xPais;

        public string fone;

        public string email;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAgencia
    {

        public string xNome;

        public string CNPJ;

        public TEndereco enderAgencia;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfBPeSub
    {

        public string chBPe;

        public TTipoSubstituicao tpSub;

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TTipoSubstituicao
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagem
    {

        public string cLocOrig;

        public string xLocOrig;

        public string cLocDest;

        public string xLocDest;

        public string dhEmb;

        public string dhValidade;

        public TBPeInfBPeInfPassagemInfPassageiro infPassageiro;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagemInfPassageiro
    {

        public string xNome;

        public string cPF;

        public TDoc tpDoc;

        public string nDoc;

        public string xDoc;

        public string dNasc;

        public string fone;

        public string email;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TDoc
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,

        /// <remarks/>
        [XmlEnum("4")]
        Item4,

        /// <remarks/>
        [XmlEnum("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagem
    {

        public string cPercurso;

        public string xPercurso;

        public TBPeInfBPeInfViagemTpViagem tpViagem;

        public TBPeInfBPeInfViagemTpServ tpServ;

        public TBPeInfBPeInfViagemTpAcomodacao tpAcomodacao;

        public TBPeInfBPeInfViagemTpTrecho tpTrecho;

        public string dhViagem;

        public string dhConexao;

        public string prefixo;

        public string poltrona;

        public string plataforma;

        public TBPeInfBPeInfViagemInfTravessia infTravessia;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpViagem
    {

        /// <remarks/>
        [XmlEnum("00")]
        Item00,

        /// <remarks/>
        [XmlEnum("01")]
        Item01,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpServ
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,

        /// <remarks/>
        [XmlEnum("4")]
        Item4,

        /// <remarks/>
        [XmlEnum("5")]
        Item5,

        /// <remarks/>
        [XmlEnum("6")]
        Item6,

        /// <remarks/>
        [XmlEnum("7")]
        Item7,

        /// <remarks/>
        [XmlEnum("8")]
        Item8,

        /// <remarks/>
        [XmlEnum("9")]
        Item9,

        [XmlEnum("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpAcomodacao
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,

        /// <remarks/>
        [XmlEnum("4")]
        Item4,

        /// <remarks/>
        [XmlEnum("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpTrecho
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagemInfTravessia
    {

        public TBPeInfBPeInfViagemInfTravessiaTpVeiculo tpVeiculo;

        public TBPeInfBPeInfViagemInfTravessiaSitVeiculo sitVeiculo;

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaTpVeiculo
    {

        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("07")]
        Item07,

        /// <remarks/>
        [XmlEnum("08")]
        Item08,

        /// <remarks/>
        [XmlEnum("09")]
        Item09,

        /// <remarks/>
        [XmlEnum("10")]
        Item10,

        /// <remarks/>
        [XmlEnum("11")]
        Item11,

        /// <remarks/>
        [XmlEnum("12")]
        Item12,

        /// <remarks/>
        [XmlEnum("13")]
        Item13,

        /// <remarks/>
        [XmlEnum("14")]
        Item14,

        /// <remarks/>
        [XmlEnum("15")]
        Item15,

        /// <remarks/>
        [XmlEnum("16")]
        Item16,

        /// <remarks/>
        [XmlEnum("17")]
        Item17,

        /// <remarks/>
        [XmlEnum("18")]
        Item18,

        /// <remarks/>
        [XmlEnum("19")]
        Item19,

        /// <remarks/>
        [XmlEnum("20")]
        Item20,

        /// <remarks/>
        [XmlEnum("21")]
        Item21,

        /// <remarks/>
        [XmlEnum("22")]
        Item22,

        /// <remarks/>
        [XmlEnum("23")]
        Item23,

        /// <remarks/>
        [XmlEnum("24")]
        Item24,

        /// <remarks/>
        [XmlEnum("25")]
        Item25,

        /// <remarks/>
        [XmlEnum("26")]
        Item26,

        /// <remarks/>
        [XmlEnum("27")]
        Item27,

        /// <remarks/>
        [XmlEnum("28")]
        Item28,

        /// <remarks/>
        [XmlEnum("29")]
        Item29,

        /// <remarks/>
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaSitVeiculo
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPe
    {

        public string vBP;

        public string vDesconto;

        public string vPgto;

        public string vTroco;

        public TBPeInfBPeInfValorBPeTpDesconto tpDesconto;

        public bool tpDescontoSpecified;

        public string xDesconto;

        public string cDesconto;

        public TBPeInfBPeInfValorBPeComp[] comp;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeTpDesconto
    {

        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("07")]
        Item07,

        /// <remarks/>
        [XmlEnum("08")]
        Item08,

        /// <remarks/>
        [XmlEnum("09")]
        Item09,

        /// <remarks/>
        [XmlEnum("10")]
        Item10,

        /// <remarks/>
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPeComp
    {

        public string vComp;

        public TBPeInfBPeInfValorBPeCompTpComp tpComp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeCompTpComp
    {

        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImp
    {

        public TImp iCMS;

        public string vTotTrib;

        public string infAdFisco;

        public TBPeInfBPeImpICMSUFFim iCMSUFFim;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImp
    {

        public object item;

        /// <remarks/>
        [XmlElement("ICMS00", typeof(TImpICMS00))]
        [XmlElement("ICMS20", typeof(TImpICMS20))]
        [XmlElement("ICMS45", typeof(TImpICMS45))]
        [XmlElement("ICMS90", typeof(TImpICMS90))]
        [XmlElement("ICMSSN", typeof(TImpICMSSN))]
        public object Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS00
    {

        public TImpICMS00CST cST;

        public string vBC;

        public string pICMS;

        public string vICMS;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS00CST
    {

        /// <remarks/>
        [XmlEnum("00")]
        Item00,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS20
    {

        public TImpICMS20CST cST;

        public string pRedBC;

        public string vBC;

        public string pICMS;

        public string vICMS;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS20CST
    {

        /// <remarks/>
        [XmlEnum("20")]
        Item20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS45
    {

        public TImpICMS45CST cST;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS45CST
    {

        /// <remarks/>
        [XmlEnum("40")]
        Item40,

        /// <remarks/>
        [XmlEnum("41")]
        Item41,

        /// <remarks/>
        [XmlEnum("51")]
        Item51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS90
    {

        public TImpICMS90CST cST;

        public string pRedBC;

        public string vBC;

        public string pICMS;

        public string vICMS;

        public string vCred;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS90CST
    {

        /// <remarks/>
        [XmlEnum("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMSSN
    {

        public TImpICMSSNCST cST;

        public TImpICMSSNIndSN indSN;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMSSNCST
    {

        /// <remarks/>
        [XmlEnum("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMSSNIndSN
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSUFFim
    {

        public string vBCUFFim;

        public string pFCPUFFim;

        public string pICMSUFFim;

        public string pICMSInter;

        public string vFCPUFFim;

        public string vICMSUFFim;

        public string vICMSUFIni;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePag
    {

        public TBPeInfBPePagTPag tPag;

        public string xPag;

        public string nDocPag;

        public string vPag;

        public TBPeInfBPePagCard card;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagTPag
    {

        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePagCard
    {

        public TBPeInfBPePagCardTpIntegra tpIntegra;

        public string cNPJ;

        public TBPeInfBPePagCardTBand tBand;

        [XmlIgnore()]

        public bool tBandSpecified;

        public string xBand;

        public string cAut;

        public string nsuTrans;

        public string nsuHost;

        public string nParcelas;

        public string infAdCard;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTpIntegra
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTBand
    {

        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAutXML
    {

        public string item;

        public ItemChoiceType1 itemElementName;

        /// <remarks/>
        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return itemElementName;
            }
            set
            {
                itemElementName = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfAdic
    {

        public string infAdFisco;

        public string infCpl;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TRespTec
    {

        public string cNPJ;

        public string xContato;

        public string email;

        public string fone;

        public string idCSRT;

        [XmlElement(DataType = "base64Binary")]
        public byte[] hashCSRT;

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeSupl
    {

        public string qrCodBPe;

        public string boardPassBPe;

    }
}
