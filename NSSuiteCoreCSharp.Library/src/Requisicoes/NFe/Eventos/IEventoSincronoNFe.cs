using NSSuiteCSharpLib.Requisicoes.NFe;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Requisicoes._Genericos.Eventos
{
    public interface IEventoSincronoNFe
    {
        void EnvioSincrono(TipoEvenDownload tpDown, string caminhoSalvar, bool exibirPDF);
    }
}
