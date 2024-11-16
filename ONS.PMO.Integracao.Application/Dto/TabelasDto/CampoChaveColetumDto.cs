using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class CampoChaveColetumDto
{
    public int IdCampochave { get; set; }

    public int IdTpcoleta { get; set; }

    public string? NomColorigemcoleta { get; set; }

    public bool FlgPrincipal { get; set; }

    public virtual CampoChaveDto IdCampochaveNavigation { get; set; } = null!;

    public virtual ColetumDto IdTpcoletaNavigation { get; set; } = null!;
}
