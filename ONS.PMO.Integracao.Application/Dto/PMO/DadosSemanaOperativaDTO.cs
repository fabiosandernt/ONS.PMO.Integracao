﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class DadosSemanaOperativaDTO
    {
        public int IdSemanaOperativa { get; set; }
        public byte[] VersaoPMO { get; set; }
        public byte[] VersaoSemanaOperativa { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }

        public bool EnviarTodos { get; set; }

        public bool ReenvioDeNotificacao { get; set; }
    }
}
