using AspNetCore.IQueryable.Extensions;
using ONS.PMO.Integracao.Domain.Filter;
using System.ComponentModel.DataAnnotations;

namespace ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU
{
    public class DisponibilidadeFilter : BaseFilter
    {
        [Display(Name = "DataInicioSemana")]
        [Required]
        public DateTime? DataInicioSemana { get; set; }

        [Display(Name = "DataFimSemana")]
        [Required]
        public DateTime? DataFimSemana { get; set; }
        public override int? Limit { get; set; } = 10;
        public override int? Offset { get; set; } = 0;
        public int? CodDpp { get; set; }
    }
}
