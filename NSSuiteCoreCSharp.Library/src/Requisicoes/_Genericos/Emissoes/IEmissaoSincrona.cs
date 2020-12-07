using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System.Runtime.Serialization;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Emissoes
{
    public interface IEmissaoDFeSincrona : IRequisicao
    {
        void EnvioSincrono(TipoDownloadDFes tpDown, string caminho, bool exibirNaTela, bool a3);
    }
    public enum TipoDownloadDFes
    {
        [EnumMember(Value = "X")]
        XML,
        [EnumMember(Value = "J")]
        JSON,
        [EnumMember(Value = "P")]
        PDF,
        [EnumMember(Value = "XP")]
        XML_PDF,
        [EnumMember(Value = "JP")]
        JSON_PDF
    }
}
