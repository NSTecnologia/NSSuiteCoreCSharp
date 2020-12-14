using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos
{
    public interface IDownloadInutilizacaoResp : IResposta
    {
        void ValidarESalvar(string caminho);
    }
}
