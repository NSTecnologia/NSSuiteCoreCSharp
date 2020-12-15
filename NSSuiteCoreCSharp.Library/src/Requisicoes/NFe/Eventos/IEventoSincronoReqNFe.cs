using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos
{
    public interface IEventoSincronoReqNFe
    {
        void EnvioSincrono(TipoEvenDownload tpDown, string caminhoSalvar, bool exibirPDF);
    }
}
