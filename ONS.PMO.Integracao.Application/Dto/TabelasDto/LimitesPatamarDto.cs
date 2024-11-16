using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LimitesPatamarDto
{
    public int IdLimpatamar { get; set; }

    public int IdLimitesintercambio { get; set; }

    public int IdTppatamar { get; set; }

    public double ValLimredecompletames1 { get; set; }

    public double ValLimredecompletames2 { get; set; }

    public double ValLimdeslig { get; set; }

    public double ValTotalhoraspatamar { get; set; }

    public virtual LimitesIntercambioDto IdLimitesintercambioNavigation { get; set; } = null!;

    public virtual PatamarDto IdTppatamarNavigation { get; set; } = null!;
}
