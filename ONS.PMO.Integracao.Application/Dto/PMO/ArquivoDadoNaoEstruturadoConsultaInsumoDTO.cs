using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ArquivoDadoNaoEstruturadoConsultaInsumoDTO
    {
        public ArquivoDadoNaoEstruturadoDTO Arquivo { get; set; }

        public String DescricaoInsumo { get; set; }

        public int IdColetaInsumo { get; set; }

        public Type GetRealType()
        {
            return this.GetType();
        }
    }
}
