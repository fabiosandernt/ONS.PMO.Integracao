using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;
using System.ComponentModel.DataAnnotations;

namespace ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU
{
    public class DisponibilidadeFilter : ICustomQueryable
    {
        [Display(Name = "DataInicioSemana")]
        [Required]
        public DateTime? DataInicioSemana { get; set; }

        [Display(Name = "DataFimSemana")]
        [Required]
        public DateTime? DataFimSemana { get; set; }
        public int? LimiteDeResultados { get; set; } = 10;
        public int? Offset { get; set; } = 0;
        public int? CodDpp { get; set; }
    }
}
