using ONS.PMO.Integracao.Domain.Entidades.PMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.PMO
{
    public class ArquivosSemanaOperativaDTO 
    {

        public ArquivosSemanaOperativaDTO()
        {
            ArquivosInsumos = new List<ArquivoDadoNaoEstruturadoConsultaInsumoDTO>();
            ArquivosEnviados = new List<ArquivoDadoNaoEstruturadoDTO>();
        }

        public SituacaoSemanaOperativa SituacaoSemanaOperativa { get; set; }

        public IList<ArquivoDadoNaoEstruturadoConsultaInsumoDTO> ArquivosInsumos { get; set; }

        public IList<ArquivoDadoNaoEstruturadoDTO> ArquivosEnviados { get; set; }

        public Type GetRealType()
        {
            return this.GetType();
        }

    }
}
