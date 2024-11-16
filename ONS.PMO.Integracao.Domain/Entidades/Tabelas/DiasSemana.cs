using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class DiasSemana
{
    public int IdDiasemana { get; set; }

    public DateOnly DatDiasemana { get; set; }

    public string FlgTpdiasemana { get; set; } = null!;

    public bool FlgFeriado { get; set; }

    public virtual ICollection<GeracaoMinimaPeriodo> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodo>();

    public virtual ICollection<LimitePeriodo> TbLimiteperiododia { get; set; } = new List<LimitePeriodo>();
}
