using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ConvergirPLDDTO
    {
        public int IdSemanaOperativa { get; set; }
        public bool Convergir { get; set; }
        public byte[] VersaoSemanaOperativa { get; set; }
        public string ObservacoesConvergenciaPld { get; set; }
    }
}
