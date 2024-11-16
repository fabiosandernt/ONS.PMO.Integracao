using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxUsinaConjuntoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int? IdUsinamontador { get; set; }

    public int? NumGruge { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontadorDto? IdUsinamontadorNavigation { get; set; }
}
