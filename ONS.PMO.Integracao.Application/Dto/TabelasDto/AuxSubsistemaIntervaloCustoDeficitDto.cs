using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxSubsistemaIntervaloCustoDeficitDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdIntervalocustodeficit { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual AuxIntervaloCustoDeficitDto IdIntervalocustodeficitNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontadorDto IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
