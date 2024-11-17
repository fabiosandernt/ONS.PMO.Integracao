using ONS.PMO.Integracao.Domain.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class ColetaInsumoFilter : BaseFilter
    {
        public int? IdColetaInsumo { get; set; }
    }
}
