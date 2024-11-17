using ONS.PMO.Integracao.Domain.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class ArquivosSemanaOperativaFilter : BaseFilter
    {
        public int IdSemanaOperativa { get; set; }
        public bool? IsConsiderarInsumosProcessamento { get; set; }
        public bool? IsConsiderarInsumosDECOMP { get; set; }
        public bool? IsConsiderarInsumosConvergenciaCCEE { get; set; }
        public bool? IsConsiderarInsumosPublicacao { get; set; }
    }
}
