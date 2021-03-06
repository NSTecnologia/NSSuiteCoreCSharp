﻿using NSSuiteCoreCSharp.Library.src.Exceptions;
using NSSuiteCoreCSharp.Library.src.Respostas._Genéricas.Utilitarios;
using System.Collections.Generic;

namespace NSSuiteCoreCSharp.Library.src.Respostas.NFe.Utilitarios
{
    public class ListarNSNRecsRespNFe : IListarNSNRecsResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public List<NSNRecs> nsNRecs { get; set; }

        public void Valida()
        {
            if (!"200".Equals(this.status))       
                throw new RequisicaoListarNSNRecException($"Erro ao listar nsnrecs de NFe: {this.status} - {this.motivo}");
        }
    }
}
