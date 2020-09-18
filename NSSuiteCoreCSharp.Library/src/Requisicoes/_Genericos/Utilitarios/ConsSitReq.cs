

namespace NSSuiteCSharpLib.Requisicoes._Genericos.Utilitarios
{
    public abstract class ConsSitReq
    {
        public string licencaCnpj { get; set; }
        public string tpAmb { get; set; }

        public abstract string EnviarConsultaSituacao();
    }
}