using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public interface IEventoSalvoResp : IResposta
    {
        void ValidarESalvar(string caminhoSalvar);
    }
}
