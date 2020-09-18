using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface IDownloadEventoReq : IRequisicao
    {   
        int tpAmb { get; set; }
        int nSeqEvento { get; set; }
    }
}
