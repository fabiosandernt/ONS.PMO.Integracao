using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LimitePeriodoDto
{
    public int IdLimiteperiododia { get; set; }

    public int IdLimitesintercambio { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValLimite { get; set; }

    public virtual DiaSemanaDto IdDiasemanaNavigation { get; set; } = null!;

    public virtual LimitesIntercambioDto IdLimitesintercambioNavigation { get; set; } = null!;

    public virtual PatamarDto IdTppatamarNavigation { get; set; } = null!;
}
