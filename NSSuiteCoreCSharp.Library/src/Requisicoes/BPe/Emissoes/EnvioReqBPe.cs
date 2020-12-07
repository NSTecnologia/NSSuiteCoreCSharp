using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Emissoes;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes;
using NSSuiteCoreCSharp.Requisicoes.BPe.Emissoes;
using NSSuiteCoreCSharp.thiss.BPe.Emissoes;
using NSSuiteCSharpLib.Respostas.BPe;
using NSSuiteCSharpLib.Respostas.BPe.Emissoes;
using System;
using System.Collections.Generic;
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

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    [XmlRoot("BPe", Namespace = "http://www.portalfiscal.inf.br/bpe", IsNullable = false)]
    [JsonObject("BPe")]
    public partial class EnvioReqBPe : SolicitavelNaAPI, IEmissaoDFeSincrona
    {
        public TBPeInfBPe infBPe { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeSupl infBPeSupl { get; set; }

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [JsonIgnore()]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SignatureType signature { get; set; }

        //Metodos de Envio para API
        public IResposta Envia()
        {
            Util.GravarLinhaLog("[ENVIO BPE INICIO]");
            string resposta = EnviaConteudoParaAPI(this, Endpoints.BPeEnvio);
            Util.GravarLinhaLog("[ENVIO BPE FIM]");

            return JsonConvert.DeserializeObject<EnvioRespBPe>(resposta);
        }
        public void EnvioSincrono(TipoDownloadDFes tpDown, string caminho, bool exibirPDF, bool a3)
        {
            Util.GravarLinhaLog("[INICIO_EMISSAO_SINCRONA_BPE]");

            var envioResposta = this.Envia() as EnvioRespBPe;
            envioResposta.Valida();

            var consultaRequisicao = new ConsStatusProcessamentoReqBPe
            {
                CNPJ = infBPe.emit.CNPJ,
                tpAmb = (int)infBPe.ide.tpAmb,
                nsNRec = envioResposta.nsNRec
            };
            ConsStatusProcessamentoRespBPe consultaResposta;
            while (true)
            {
                consultaResposta = consultaRequisicao.Envia() as ConsStatusProcessamentoRespBPe;
                try
                {
                    consultaResposta.Valida();
                    break;
                }
                catch(InvalidOperationException)
                {
                    continue;
                }
            }

            var downloadRequisicao = new DownloadReqBPe
            {
                tpDown = tpDown,
                tpAmb = (int)infBPe.ide.tpAmb,
                chBPe = consultaResposta.chBPe
            };
            var downloadResposta = downloadRequisicao.Envia() as DownloadRespBPe;
            downloadResposta.ValidarESalvar(caminho, exibirPDF);

            Util.GravarLinhaLog("[FIM_EMISSAO_SINCRONA_BPE]");
        }
        public override string ToJSONString()
        {
            JObject root = JObject.FromObject(new { BPe = this });
            return JsonConvert.SerializeObject(root, Formatting.Indented);
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPe
    {
        public TBPeInfBPeIde ide { get; set; }

        public TBPeInfBPeEmit emit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeComp comp { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeAgencia agencia { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeInfBPeSub infBPeSub { get; set; }

        public TBPeInfBPeInfPassagem infPassagem { get; set; }

        [XmlElement("infViagem")]
        public List<TBPeInfBPeInfViagem> infViagem { get; set; }

        public TBPeInfBPeInfValorBPe infValorBPe { get; set; }

        public TBPeInfBPeImp imp { get; set; }

        [XmlElement("pag")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TBPeInfBPePag> pag { get; set; }

        [XmlElement("autXML")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TBPeInfBPeAutXML> autXML { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeInfAdic infAdic { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TRespTec infRespTec { get; set; }

        [XmlAttribute()]
        public string versao { get; set; }

        [XmlAttribute(DataType = "ID")]
        [JsonIgnore()]
        public string Id { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeIde
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TCodUfIBGE cUF { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TAmb tpAmb { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TModBPe mod { get; set; }

        public string serie { get; set; }

        public string nBP { get; set; }

        public string cBP { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonIgnore()]
        public string cDV { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeModal modal { get; set; }

        public string dhEmi { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeTpEmis tpEmis { get; set; }

        public string verProc { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeIdeTpBPe tpBPe { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TIndPres indPres { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf_sem_EX UFIni { get; set; }

        public string cMunIni { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf UFFim { get; set; }

        public string cMunFim { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dhCont { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xJust { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TCodUfIBGE
    {
        [EnumMember(Value = "11")]
        [XmlEnum("11")]
        RO,

        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        AC,

        [EnumMember(Value = "13")]
        [XmlEnum("13")]
        AM,

        [EnumMember(Value = "14")]
        [XmlEnum("14")]
        RR,

        [EnumMember(Value = "15")]
        [XmlEnum("15")]
        PA,

        [EnumMember(Value = "16")]
        [XmlEnum("16")]
        AP,

        [EnumMember(Value = "17")]
        [XmlEnum("17")]
        TO,

        [EnumMember(Value = "21")]
        [XmlEnum("21")]
        MA,

        [EnumMember(Value = "22")]
        [XmlEnum("22")]
        PI,

        [EnumMember(Value = "23")]
        [XmlEnum("23")]
        CE,

        [EnumMember(Value = "24")]
        [XmlEnum("24")]
        RN,

        [EnumMember(Value = "25")]
        [XmlEnum("25")]
        PB,

        [EnumMember(Value = "26")]
        [XmlEnum("26")]
        PE,

        [EnumMember(Value = "27")]
        [XmlEnum("27")]
        AL,

        [EnumMember(Value = "28")]
        [XmlEnum("28")]
        SE,

        [EnumMember(Value = "29")]
        [XmlEnum("29")]
        BA,

        [EnumMember(Value = "31")]
        [XmlEnum("31")]
        MG,

        [EnumMember(Value = "32")]
        [XmlEnum("32")]
        ES,

        [EnumMember(Value = "33")]
        [XmlEnum("33")]
        RJ,

        [EnumMember(Value = "35")]
        [XmlEnum("35")]
        SP,

        [EnumMember(Value = "41")]
        [XmlEnum("41")]
        PR,

        [EnumMember(Value = "42")]
        [XmlEnum("42")]
        SC,

        [EnumMember(Value = "43")]
        [XmlEnum("43")]
        RS,

        [EnumMember(Value = "50")]
        [XmlEnum("50")]
        MS,

        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        MT,

        [EnumMember(Value = "52")]
        [XmlEnum("52")]
        GO,

        [EnumMember(Value = "53")]
        [XmlEnum("53")]
        DF,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TAmb
    {

        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Producao = 1,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Homologacao = 2,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TModBPe
    {
        [EnumMember(Value = "63")]
        [XmlEnum("63")]
        BPe,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeModal
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Rodoviario,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Aquaviario,

        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Ferroviario,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpEmis
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Normal,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Contingencia,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpBPe
    {
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Normal,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Substituicao,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TIndPres
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        OpPresencialNaoEmbarcado = 1,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        OpNaoPresencialInternet = 2,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        OpNaoPresencialTeleatendimento = 3,

        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        EntregaADomicilio = 4,

        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        OpPresenscialEmbarcada = 5,

        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        OpNaoPresencialOutros = 9,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TUf_sem_EX
    {
        [EnumMember(Value = "AC")]
        AC,

        [EnumMember(Value = "AL")]
        AL,

        [EnumMember(Value = "AM")]
        AM,

        [EnumMember(Value = "AP")]
        AP,

        [EnumMember(Value = "BA")]
        BA,

        [EnumMember(Value = "CE")]
        CE,

        [EnumMember(Value = "DF")]
        DF,

        [EnumMember(Value = "ES")]
        ES,

        [EnumMember(Value = "GO")]
        GO,

        [EnumMember(Value = "MA")]
        MA,

        [EnumMember(Value = "MG")]
        MG,

        [EnumMember(Value = "MS")]
        MS,

        [EnumMember(Value = "MT")]
        MT,

        [EnumMember(Value = "PA")]
        PA,

        [EnumMember(Value = "PB")]
        PB,

        [EnumMember(Value = "PE")]
        PE,

        [EnumMember(Value = "PI")]
        PI,

        [EnumMember(Value = "PR")]
        PR,

        [EnumMember(Value = "RJ")]
        RJ,

        [EnumMember(Value = "RN")]
        RN,

        [EnumMember(Value = "RO")]
        RO,

        [EnumMember(Value = "RR")]
        RR,

        [EnumMember(Value = "RS")]
        RS,

        [EnumMember(Value = "SC")]
        SC,

        [EnumMember(Value = "SE")]
        SE,

        [EnumMember(Value = "SP")]
        SP,

        [EnumMember(Value = "TO")]
        TO,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TUf
    {
        [EnumMember(Value = "AC")]
        AC,

        [EnumMember(Value = "AL")]
        AL,

        [EnumMember(Value = "AM")]
        AM,

        [EnumMember(Value = "AP")]
        AP,

        [EnumMember(Value = "BA")]
        BA,

        [EnumMember(Value = "CE")]
        CE,

        [EnumMember(Value = "DF")]
        DF,

        [EnumMember(Value = "ES")]
        ES,

        [EnumMember(Value = "GO")]
        GO,

        [EnumMember(Value = "MA")]
        MA,

        [EnumMember(Value = "MG")]
        MG,

        [EnumMember(Value = "MS")]
        MS,

        [EnumMember(Value = "MT")]
        MT,

        [EnumMember(Value = "PA")]
        PA,

        [EnumMember(Value = "PB")]
        PB,

        [EnumMember(Value = "PE")]
        PE,

        [EnumMember(Value = "PI")]
        PI,

        [EnumMember(Value = "PR")]
        PR,

        [EnumMember(Value = "RJ")]
        RJ,

        [EnumMember(Value = "RN")]
        RN,

        [EnumMember(Value = "RO")]
        RO,

        [EnumMember(Value = "RR")]
        RR,

        [EnumMember(Value = "RS")]
        RS,

        [EnumMember(Value = "SC")]
        SC,

        [EnumMember(Value = "SE")]
        SE,

        [EnumMember(Value = "SP")]
        SP,

        [EnumMember(Value = "TO")]
        TO,

        [EnumMember(Value = "EX")]
        EX,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeEmit
    {
        public string CNPJ { get; set; }

        public string IE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IEST { get; set; }

        public string xNome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xFant { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }

        public string CNAE { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeEmitCRT CRT { get; set; }

        public TEndeEmi enderEmit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TAR { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeEmitCRT
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        SimplesNacional,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        SimplesNacionalMenosRendaBruta,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        RegimeNormal,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TEndeEmi
    {
        public string xLgr { get; set; }

        public string nro { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl { get; set; }

        public string xBairro { get; set; }

        public string cMun { get; set; }

        public string xMun { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEP { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TUf_sem_EX UF { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }

    }

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
        public string IE { get; set; }

        public TEndereco enderComp { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TEndereco
    {
        public string xLgr { get; set; }

        public string nro { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xCpl { get; set; }

        public string xBairro { get; set; }

        public string cMun { get; set; }

        public string xMun { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CEP { get; set; }

        public TUf UF { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cPais { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xPais { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAgencia
    {
        public string xNome { get; set; }

        public string CNPJ { get; set; }

        public TEndereco enderAgencia { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfBPeSub
    {
        public string chBPe { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TTipoSubstituicao tpSub { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TTipoSubstituicao
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Remarcacao,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Trasferencia,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        TransferenciaERemarcacao,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagem
    {
        public string cLocOrig { get; set; }

        public string xLocOrig { get; set; }

        public string cLocDest { get; set; }

        public string xLocDest { get; set; }

        public string dhEmb { get; set; }

        public string dhValidade { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeInfPassagemInfPassageiro infPassageiro { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagemInfPassageiro
    {
        public string xNome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TDoc tpDoc { get; set; }

        public string nDoc { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xDoc { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dNasc { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TDoc
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        RG,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        TituloEleitor,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Passaporte,

        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        CNH,

        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagem
    {
        public string cPercurso { get; set; }

        public string xPercurso { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemTpViagem tpViagem { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemTpServ tpServ { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemTpAcomodacao tpAcomodacao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemTpTrecho tpTrecho { get; set; }

        public string dhViagem { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dhConexao { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string prefixo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string poltrona { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string plataforma { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeInfViagemInfTravessia infTravessia { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpViagem
    {
        [EnumMember(Value = "00")]
        [XmlEnum("00")]
        Regular,

        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Extra,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpServ
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        ConvencionalComSanitario,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        ConvencionalSemSanitario,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Semileito,

        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        LeitoComArCondicionado,

        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        LeitoSemArCondicionado,

        [EnumMember(Value = "6")]
        [XmlEnum("6")]
        Executivo,

        [EnumMember(Value = "7")]
        [XmlEnum("7")]
        Semiurbano,

        [EnumMember(Value = "8")]
        [XmlEnum("8")]
        Longitudinal,

        [EnumMember(Value = "9")]
        [XmlEnum("9")]
        Travessia,

        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        Cama,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpAcomodacao
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Assento_Poltrona,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Rede,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        RedeComArCondicionado,

        [EnumMember(Value = "4")]
        [XmlEnum("4")]
        Cabine,

        [EnumMember(Value = "5")]
        [XmlEnum("5")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpTrecho
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Normal,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        TrecoInicial,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Conexao,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagemInfTravessia
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemInfTravessiaTpVeiculo tpVeiculo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfViagemInfTravessiaSitVeiculo sitVeiculo { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaTpVeiculo
    {
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Motocicleta,

        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Automovel,

        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        AutomovelComReboque,

        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        Caminhote,

        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        CaminhoteComReboque,

        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        MicroOnibus,

        [EnumMember(Value = "07")]
        [XmlEnum("07")]
        Van,

        [EnumMember(Value = "08")]
        [XmlEnum("08")]
        Onibus_2ou3Eixos,

        [EnumMember(Value = "09")]
        [XmlEnum("09")]
        Onibus_4Eixos,

        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        Caminhao3por4,

        [EnumMember(Value = "11")]
        [XmlEnum("11")]
        CaminhaoToco,

        [EnumMember(Value = "12")]
        [XmlEnum("12")]
        CaminhaoTruck,

        [EnumMember(Value = "13")]
        [XmlEnum("13")]
        Carreta,

        [EnumMember(Value = "14")]
        [XmlEnum("14")]
        BiTrem,

        [EnumMember(Value = "15")]
        [XmlEnum("15")]
        RodoTrem_9Eixos,

        [EnumMember(Value = "16")]
        [XmlEnum("16")]
        RomeuEJulieta_7Eixos,

        [EnumMember(Value = "17")]
        [XmlEnum("17")]
        Jamanta_6Eixos,

        [EnumMember(Value = "18")]
        [XmlEnum("18")]
        Jamanta_5Eixos,

        [EnumMember(Value = "19")]
        [XmlEnum("19")]
        Jamanta_4Eixos,

        [EnumMember(Value = "20")]
        [XmlEnum("20")]
        TratorEsteira,

        [EnumMember(Value = "21")]
        [XmlEnum("21")]
        PaMecanica,

        [EnumMember(Value = "22")]
        [XmlEnum("22")]
        Patrola,

        [EnumMember(Value = "23")]
        [XmlEnum("23")]
        TratorPneuGrande,

        [EnumMember(Value = "24")]
        [XmlEnum("24")]
        TratorPneuComReboque,

        [EnumMember(Value = "25")]
        [XmlEnum("25")]
        TratorPneuSemReboque,

        [EnumMember(Value = "26")]
        [XmlEnum("26")]
        Carroca,

        [EnumMember(Value = "27")]
        [XmlEnum("27")]
        Mobilete,

        [EnumMember(Value = "28")]
        [XmlEnum("28")]
        Bicicleta,

        [EnumMember(Value = "29")]
        [XmlEnum("29")]
        Passageiro,

        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaSitVeiculo
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Vazio,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Carregado,

        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        NaoSeAplica,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPe
    {
        public string vBP { get; set; }

        public string vDesconto { get; set; }

        public string vPgto { get; set; }

        public string vTroco { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfValorBPeTpDesconto? tpDesconto{ get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xDesconto{ get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cDesconto{ get; set; }

        public List<TBPeInfBPeInfValorBPeComp> Comp{ get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeTpDesconto
    {
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        TarifaPromocional,

        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Idoso,

        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        Crianca,

        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        Deficiente,

        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        Estudante,

        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        AnimalDomestico,

        [EnumMember(Value = "07")]
        [XmlEnum("07")]
        AcordoColetivo,

        [EnumMember(Value = "08")]
        [XmlEnum("08")]
        ProfissinalEmDeslocamento,

        [EnumMember(Value = "09")]
        [XmlEnum("09")]
        ProfissionalDaEmpresa,

        [EnumMember(Value = "10")]
        [XmlEnum("10")]
        Jovem,

        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPeComp
    {
        public string vComp{ get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeInfValorBPeCompTpComp tpComp { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeCompTpComp
    {
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Tarifa,

        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Pedagio,

        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        TaxaEmbarque,

        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        Seguro,

        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        TMR,

        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        SVI,

        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImp
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vTotTrib { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string infAdFisco { get; set; }

        public TBPeInfBPeImpICMS ICMS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSUFFim ICMSUFFim { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMS
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSICMS00 ICMS00 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSICMS20 ICMS20 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSICMS45 ICMS45 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSICMS90 ICMS90 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPeImpICMSICMSSN ICMSSN { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSICMS00
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMS00CST CST { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMS00CST
    {
        [EnumMember(Value = "00")]
        [XmlEnum("00")]
        CST00,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSICMS20
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMS20CST CST { get; set; }

        public string pRedBC { get; set; }

        public string vBC { get; set; }

        public string pICMS { get; set; }

        public string vICMS { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMS20CST
    {
        [EnumMember(Value = "20")]
        [XmlEnum("20")]
        CST20,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSICMS45
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMS45CST CST;
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMS45CST
    {
        [EnumMember(Value = "40")]
        [XmlEnum("40")]
        CST40,

        [EnumMember(Value = "41")]
        [XmlEnum("41")]
        CST41,

        [EnumMember(Value = "51")]
        [XmlEnum("51")]
        CST51,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSICMS90
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMS90CST CST { get; set; }

        public string vBC { get; set; }

        public string pICMS { get; set; }

        public string vICMS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pRedBC { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vCred { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMS90CST
    {
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        CST90,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSICMSSN
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMSSNCST CST { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPeImpICMSICMSSNIndSN indSN { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMSSNCST
    {
        [EnumMember(Value = "90")]
        [XmlEnum("90")]
        CST90,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeImpICMSICMSSNIndSN
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Sim,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSUFFim
    {
        public string vBCUFFim { get; set; }
        public string pFCPUFFim { get; set; }
        public string pICMSUFFim { get; set; }
        public string pICMSInter { get; set; }
        public string vFCPUFFim { get; set; }
        public string vICMSUFFim { get; set; }
        public string vICMSUFIni { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePag
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPePagTPag tPag { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xPag { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nDocPag { get; set; }

        public string vPag { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TBPeInfBPePagCard card { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagTPag
    {
        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Dinheiro,

        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        Cheque,

        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        CartaoDeCredito,

        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        CretaoDeDebito,

        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        ValeTransporte,

        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePagCard
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPePagCardTpIntegra tpIntegra { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TBPeInfBPePagCardTBand? tBand { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string xBand { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cAut { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nsuTrans { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nsuHost { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string nParcelas { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string infAdCard { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTpIntegra
    {
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        IntegradoComSistemaDeAutomacao,

        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        NaoIntegradoComSistemaDeAutomacao
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTBand
    {

        [EnumMember(Value = "01")]
        [XmlEnum("01")]
        Visa,

        [EnumMember(Value = "02")]
        [XmlEnum("02")]
        MasterCard,

        [EnumMember(Value = "03")]
        [XmlEnum("03")]
        AmericanExpress,

        [EnumMember(Value = "04")]
        [XmlEnum("04")]
        Sorocred,

        [EnumMember(Value = "05")]
        [XmlEnum("05")]
        Elo,

        [EnumMember(Value = "06")]
        [XmlEnum("06")]
        Diners,

        [EnumMember(Value = "99")]
        [XmlEnum("99")]
        Outros,
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAutXML
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfAdic
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string infAdFisco { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string infCpl { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TRespTec
    {
        public string CNPJ { get; set; }

        public string xContato { get; set; }

        public string email { get; set; }

        public string fone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string idCSRT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement(DataType = "base64Binary")]
        public byte[] hashCSRT { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeSupl
    {
        public string qrCodBPe { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string boardPassBPe { get; set; }

    }
}
