using NSSuiteCSharpLib.Requisicoes.BPe.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface ICorrecaoSincrona : ICorrigirReq
    {
        void EnvioSincrono(TipoDownloadEventoBPe tpDown, string caminho, bool exibirPDF);
    }
}
