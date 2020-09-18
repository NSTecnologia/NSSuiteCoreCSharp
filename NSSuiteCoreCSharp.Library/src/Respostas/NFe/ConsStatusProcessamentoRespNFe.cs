
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas;

namespace NSSuiteCSharpLib.Respostas.NFe
{
    public class ConsStatusProcessamentoRespNFe : IConsStatusProcessamentoResp
    {
        public string chNFe { get; set; }
        public string xMotivo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string dhRecbto { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Erro erro { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string cStat { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string nProt { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string xml { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string motivo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Valida()
        {
            throw new System.NotImplementedException();
        }
    }
}