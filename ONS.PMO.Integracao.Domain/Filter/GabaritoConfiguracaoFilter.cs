using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Filter
{
    public class GabaritoConfiguracaoFilter : BaseFilter
    {
        public GabaritoConfiguracaoFilter()
        {
            IdsOrigemColeta = new List<string>();
            IdsInsumo = new List<int>();
        }

        public bool IsOrigemColetaNull { get; set; }
        public bool IsPadrao { get; set; }
        public int? IdSemanaOperativa { get; set; }
        public int? IdAgente { get; set; }
        public string IdOrigemColetaPai { get; set; }
        public int? IdInsumo { get; set; }
        public string TipoInsumo { get; set; }
        public string CodigoPerfilONS { get; set; }
        public bool IsNullCodigoPerfilONS { get; set; }
        public IList<string> IdsOrigemColeta { get; set; }
        public IList<int> IdsInsumo { get; set; }
    }
}
