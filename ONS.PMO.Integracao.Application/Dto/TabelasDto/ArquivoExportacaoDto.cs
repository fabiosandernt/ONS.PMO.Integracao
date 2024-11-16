using ONS.PMO.Integracao.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto
{
    public class ArquivoExportacaoDto
    {
        public int IdArquivoexportacao { get; set; }

        public string NomArquivoexportacao { get; set; } = null!;

        public string? DscArquivoexportacao { get; set; }

        public virtual ICollection<BlocoDto> TbBlocos { get; set; } = new List<BlocoDto>();

        public virtual ICollection<ExportacaoArquivoTextoDto> TbExportacaoarquivotextos { get; set; } = new List<ExportacaoArquivoTextoDto>();
    }
}
