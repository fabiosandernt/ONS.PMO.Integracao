using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PrestricaoDto
{
    public int IdTprestricao { get; set; }

    public string CodTprestricao { get; set; } = null!;

    public string? DscTprestricao { get; set; }

    public virtual ICollection<RestricaoEstudoDto> TbRestricaoestudos { get; set; } = new List<RestricaoEstudoDto>();

    public virtual ICollection<BlocoDto> IdBlocos { get; set; } = new List<BlocoDto>();
}
