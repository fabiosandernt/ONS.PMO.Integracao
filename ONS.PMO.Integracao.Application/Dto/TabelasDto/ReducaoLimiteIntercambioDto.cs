using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ReducaoLimiteIntercambioDto
{
    public int IdReducaolimiteintercambio { get; set; }

    public int IdLimitesintercambio { get; set; }

    public string DscMotivo { get; set; } = null!;

    public string TipReducaolimiteintercambio { get; set; } = null!;

    public DateTime DinInicio { get; set; }

    public DateTime DinFim { get; set; }

    public double ValLimite { get; set; }

    public long? NumIntervencaosgi { get; set; }

    public virtual LimitesIntercambioDto IdLimitesintercambioNavigation { get; set; } = null!;
}
