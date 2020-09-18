using NSSuiteCoreCSharp.Requisicoes._Genericos.Padroes;
using NSSuiteCoreCSharp.Respostas._Genéricas;
using NSSuiteCoreCSharp.Respostas._Genéricas.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSSuiteCoreCSharp.Respostas.BPe.Eventos
{
    public class ExcessoBagagemRespBPe : IResposta, IEventoSalvoRespBPe
    {
        public string status { get; set; }
        public string motivo { get; set; }

        public void Valida()
        {
            throw new NotImplementedException();
        }

        public void ValidaESalvaXML(string caminhoSalvar)
        {
            throw new NotImplementedException();
        }
    }
}
