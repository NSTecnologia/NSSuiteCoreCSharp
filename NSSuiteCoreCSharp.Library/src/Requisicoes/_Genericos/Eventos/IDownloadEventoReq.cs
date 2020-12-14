using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NSSuiteCoreCSharp.Requisicoes._Genericos.Eventos
{
    public interface IDownloadEventoReq : IRequisicao
    {   
        int nSeqEvento { get; set; }
    }
    public enum TipoEvenDownload
    {
        [EnumMember(Value = "XP")]
        XML_E_PDF,
        [EnumMember(Value = "X")]
        XML,
        [EnumMember(Value = "P")]
        PDF
    }
}
