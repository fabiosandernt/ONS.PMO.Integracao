using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxPequenaUsinaDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdSubsistemamontador { get; set; }

    public string NomPequenausina { get; set; } = null!;

    public string? DscPequenausina { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontadorDto IdSubsistemamontadorNavigation { get; set; } = null!;
}
