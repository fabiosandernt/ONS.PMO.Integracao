using ONS.PMO.Integracao.Domain.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class EnviarDadosColetaInsumoFilter : BaseFilter
    {
        public EnviarDadosColetaInsumoFilter()
        {
            IdsColetaInsumo = new List<int>();
        }

        public IList<int> IdsColetaInsumo { get; set; }
        public int IdSemanaOperativa { get; set; }
        public IList<string> VersoesString { get; set; }
    }
}
