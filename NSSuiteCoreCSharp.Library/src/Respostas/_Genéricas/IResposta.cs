namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas
{
    public interface IResposta
    {
        string status { get; set; }
        string motivo { get; set; }
        void Valida();
    }
}
