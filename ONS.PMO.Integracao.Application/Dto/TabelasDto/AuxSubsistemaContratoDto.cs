using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxSubsistemaContratoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdContrato { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual AuxContratoDto IdContratoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontadorDto IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
