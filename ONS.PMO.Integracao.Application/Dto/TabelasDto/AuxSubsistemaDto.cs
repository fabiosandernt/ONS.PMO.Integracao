using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxSubsistemaDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public virtual OrigemColetumDto IdOrigemcoletaNavigation { get; set; } = null!;
}
