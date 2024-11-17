using ONS.PMO.Integracao.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto
{
    public class TbArquivoexportacaoDto
    {
        public int IdArquivoexportacao { get; set; }

        public string NomArquivoexportacao { get; set; } = null!;

        public string? DscArquivoexportacao { get; set; }

        public virtual ICollection<TbBlocoDto> TbBlocos { get; set; } = new List<TbBlocoDto>();

        public virtual ICollection<TbExportacaoarquivotextoDto> TbExportacaoarquivotextos { get; set; } = new List<TbExportacaoarquivotextoDto>();
    }
}
