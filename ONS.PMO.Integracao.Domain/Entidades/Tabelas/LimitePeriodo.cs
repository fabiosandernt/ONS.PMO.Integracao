using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class LimitePeriodo
{
    public int IdLimiteperiododia { get; set; }

    public int IdLimitesintercambio { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValLimite { get; set; }

    public virtual DiasSemana IdDiasemanaNavigation { get; set; } = null!;

    public virtual LimitesIntercambio IdLimitesintercambioNavigation { get; set; } = null!;

    public virtual Patamar IdTppatamarNavigation { get; set; } = null!;
}
