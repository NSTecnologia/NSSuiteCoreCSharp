using NSSuiteCSharpLib.Respostas._Genéricas;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Eventos
{
    public class RetInutNFe : IRetInut
    {
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string chave { get; set; }
        public string tpAmb { get; set; }
        public string nProt { get; set; }
        public string dhRecbto { get; set; }
        public string xmlInut { get ; set; }
    }
}
