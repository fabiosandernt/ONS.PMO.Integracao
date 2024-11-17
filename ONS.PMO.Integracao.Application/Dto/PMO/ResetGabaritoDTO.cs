using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ResetGabaritoDTO
    {
        public int IdSemanaOperativa { get; set; }
        public int? IdEstudo { get; set; }
        public bool IsPadrao { get; set; }
        public byte[] VersaoPMO { get; set; }
        public byte[] VersaoSemanaOperativa { get; set; }
    }
}
