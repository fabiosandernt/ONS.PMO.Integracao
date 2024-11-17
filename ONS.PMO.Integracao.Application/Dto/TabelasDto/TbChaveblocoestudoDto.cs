using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbChaveblocoestudoDto
{
    public int IdChaveblocoestudo { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdRestricao { get; set; }

    public virtual TbBlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual TbRestricaoDto? IdRestricaoNavigation { get; set; }
}
