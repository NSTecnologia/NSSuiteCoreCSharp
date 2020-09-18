
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Commons;
using NSSuiteCSharpLib.Requisicoes._Genericos;
using NSSuiteCSharpLib.Requisicoes._Genericos.Eventos;
using System.Collections.Generic;

namespace NSSuiteCSharpLib.Requisicoes.CTe
{
    public class InfCorrecao
    {
        public string grupoAlterado { get; set; }
        public string campoAlterado { get; set; }
        public string valorAlterado { get; set; }
        public string nroItemAlterado { get; set; }
    }
    public class CorrigirReqCTe
    {
        public string chCTe { get; set; }
        public List<InfCorrecao> infCorrecao { get; set; }
    }


}