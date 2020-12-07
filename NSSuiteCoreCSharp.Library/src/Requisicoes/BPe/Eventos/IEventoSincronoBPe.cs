using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes.BPe.Eventos
{
    public interface IEventoSincronoBPe
    {
        void EnvioSincrono(string caminhoSalvar);
    }
}
