using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCSharpLib.Respostas._Genéricas.Emissoes;
using System.Collections.Generic;
public class EmitirRespNFCe : IEnvioResp
{  
    public string status { get; set; }
    public string motivo { get; set; }
    public string xMotivo { get; set; }
    public List<string> erros { get; set; }
    public Erro erro { get; set; }
    public NfeProc nfeProc { get; set; }
    public string nsNRec { get; set; }

    public void Valida()
    {
        throw new System.NotImplementedException();
    }
}