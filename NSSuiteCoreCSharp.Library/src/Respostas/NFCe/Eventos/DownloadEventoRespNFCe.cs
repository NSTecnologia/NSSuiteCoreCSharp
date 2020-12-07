using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFCe.Eventos
{
    public class DownloadEventoRespNFCe : IResposta
    {
        public string status { get; set; }
        public string motivo { get; set; }

        public void Valida()
        {
            throw new NotImplementedException();
        }
    }
}
