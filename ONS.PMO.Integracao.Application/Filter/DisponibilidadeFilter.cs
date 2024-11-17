

using ONS.PMO.Integracao.Domain.Filter;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class DisponibilidadeFilterDto : BaseFilter
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string[]? SglInsumo { get; set; }
     
    }
}
