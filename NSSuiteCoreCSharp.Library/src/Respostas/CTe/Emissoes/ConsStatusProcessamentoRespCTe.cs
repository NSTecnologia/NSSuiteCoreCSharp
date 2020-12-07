
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas;

namespace NSSuiteCSharpLib.Respostas.CTe
{
    public class ConsStatusProcessamentoRespCTe : IConsStatusProcessamentoResp
    {
        public string chCTe { get; set; }
        public string xMotivo { get; set; }
        public string dhRecbto { get; set; }
        public Erro erro { get; set; }
        public string cStat { get; set; }
        public string nProt { get; set; }
        public string xml { get; set; }
        public string status { get; set; }
        public string motivo { get; set; }

        public void Valida()
        {
            throw new System.NotImplementedException();
        }
    }
}