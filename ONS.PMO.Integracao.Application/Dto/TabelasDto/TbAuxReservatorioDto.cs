using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxReservatorioDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public int CodDpp { get; set; }

    public string? NomLongo { get; set; }

    public string? NomCurto { get; set; }

    public virtual TbOrigemcoletumDto IdOrigemcoletaNavigation { get; set; } = null!;
}
