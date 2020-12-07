using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Eventos
{
    public interface IDownloadEventoResp : IResposta
    {
        void ValidarESalvar(string caminho, bool exibirPDF);
    }
}
