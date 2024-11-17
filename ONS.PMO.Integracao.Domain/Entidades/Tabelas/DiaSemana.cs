using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class DiaSemana
{
    public int IdDiasemana { get; set; }

    public DateOnly DatDiasemana { get; set; }

    public string FlgTpdiasemana { get; set; } = null!;

    public bool FlgFeriado { get; set; }

    public virtual ICollection<GeracaoMinimaPeriodoDia> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodoDia>();

    public virtual ICollection<LimitePeriodoDia> TbLimiteperiododia { get; set; } = new List<LimitePeriodoDia>();
}
