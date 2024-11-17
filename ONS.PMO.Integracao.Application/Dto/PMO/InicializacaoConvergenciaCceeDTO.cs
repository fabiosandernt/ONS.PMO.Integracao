using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class InicializacaoConvergenciaCceeDTO
    {
        public int IdSemanaOperativa { get; set; }
        public byte[] VersaoSemanaOperativa { get; set; }
        public ISet<ArquivoDadoNaoEstruturadoDTO> Arquivos { get; set; }
    }
}
