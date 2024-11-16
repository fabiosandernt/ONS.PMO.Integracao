using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ChaveBlocoEstudoDto
{
    public int IdChaveblocoestudo { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdRestricao { get; set; }

    public virtual BlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual RestricaoDto? IdRestricaoNavigation { get; set; }
}
