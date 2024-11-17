using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbLimiteperiododiumDto
{
    public int IdLimiteperiododia { get; set; }

    public int IdLimitesintercambio { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValLimite { get; set; }

    public virtual TbDiasemanaDto IdDiasemanaNavigation { get; set; } = null!;

    public virtual TbLimitesintercambioDto IdLimitesintercambioNavigation { get; set; } = null!;

    public virtual TbTppatamarDto IdTppatamarNavigation { get; set; } = null!;
}
