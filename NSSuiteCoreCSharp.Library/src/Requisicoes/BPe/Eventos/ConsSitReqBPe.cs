
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos.Utilitarios;

namespace NSSuiteCoreCSharp.Requisicoes.BPe.Eventos
{
    public class ConsSitReqBPe : ConsSitReq
    {
        public string chBPe { get; set; }

        public override string EnviarConsultaSituacao()
        {
            throw new System.NotImplementedException();
        }
    }
}
