using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxPequenausinaDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdSubsistemamontador { get; set; }

    public string NomPequenausina { get; set; } = null!;

    public string? DscPequenausina { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontadorDto IdSubsistemamontadorNavigation { get; set; } = null!;
}
