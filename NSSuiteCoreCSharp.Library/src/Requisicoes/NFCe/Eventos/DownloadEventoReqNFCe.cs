
using Newtonsoft.Json;
using NSSuiteCoreCSharp.Library.src.Commons;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas;
using NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos;
using NSSuiteCSharpLib.Genericos.Exceptions;
using NSSuiteCSharpLib.Requisicoes.NFCe;
using NSSuiteCSharpLib.Respostas.NFCe;
using System;
using System.Diagnostics;
using System.IO;

namespace NSSuiteCoreCSharp.Requisicoes.NFCe.Eventos
{
    public class DownloadEventoReqNFCe : SolicitavelNaAPI, IDownloadEventoReq
    {
        public string chNFe { get; set; }
        public Impressao impressao { get; set; }
        public int tpAmb { get; set; }
        public int nSeqEvento { get; set; }

        public IResposta Envia()
        {
            throw new NotImplementedException();
        }
    }
}