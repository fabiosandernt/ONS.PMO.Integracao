using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTprestricaoDto
{
    public int IdTprestricao { get; set; }

    public string CodTprestricao { get; set; } = null!;

    public string? DscTprestricao { get; set; }

    public virtual ICollection<TbRestricaoestudoDto> TbRestricaoestudos { get; set; } = new List<TbRestricaoestudoDto>();

    public virtual ICollection<TbBlocoDto> IdBlocos { get; set; } = new List<TbBlocoDto>();
}
