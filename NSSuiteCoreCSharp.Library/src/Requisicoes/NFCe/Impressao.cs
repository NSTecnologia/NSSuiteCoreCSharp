using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NSSuiteCSharpLib.Requisicoes.NFCe
{
    public class Impressao
    {
        [JsonProperty("tipo", Required = Required.Always)]
        public ImpressaoTipo tipo { get; set; } = ImpressaoTipo.PDF;

        [JsonProperty("ecologica", Required = Required.Default)]
        public bool ecologica { get; set; } = false;

        [JsonProperty("itemLinhas", Required = Required.Default)]
        public ImpressaoNumLinhas itemLinhas { get; set; } = ImpressaoNumLinhas.uma_linha;

        [JsonProperty("itemDesconto", Required = Required.Default)]
        public bool itemDesconto { get; set; } = true;

        [JsonProperty("larguraPapel", Required = Required.Default)]
        public ImpressaoLarguraPapel larguraPapel { get; set; } = ImpressaoLarguraPapel.oitenta_milimetros;

        [JsonProperty("modMiniImpressora", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public ImpressaoMiniImpressora? modMiniImpressora { get; set; } = null;
    }
    public enum ImpressaoTipo
    {
        [EnumMember(Value = "PDF")]
        PDF,
        [EnumMember(Value = "ESCPOS")]
        ESCPOS
    }
    public enum ImpressaoLarguraPapel
    {
        [EnumMember(Value = "80mm")]
        oitenta_milimetros,
        [EnumMember(Value = "58mm")]
        cinquenta_e_oito_milimetros

    }
    public enum ImpressaoNumLinhas
    {
        [EnumMember(Value = "1")]
        uma_linha,
        [EnumMember(Value = "2")]
        duas_linhas
    }
    public enum ImpressaoMiniImpressora
    {
        [EnumMember(Value = "BEMATECH MP-4200 TH")]
        BEMATECH_MP_4200_TH,
        [EnumMember(Value = "BEMATECH MP-2500 TH")]
        BEMATECH_MP_2500_TH,
        [EnumMember(Value = "DARUMA")]
        DARUMA,
        [EnumMember(Value = "EPSON T20")]
        EPSON_T20,
        [EnumMember(Value = "EPSON T70")]
        EPSON_T70,
        [EnumMember(Value = "ELGIN I9")]
        ELGIN_I9
    }
}