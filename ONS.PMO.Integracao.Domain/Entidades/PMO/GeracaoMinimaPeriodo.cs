using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class GeracaoMinimaPeriodo
{
    public int IdGeracaominimaperiododia { get; set; }

    public int IdConjuntogeracaominima { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValGeracaominimaperiododia { get; set; }

    public virtual ConjuntoGeracaoMinima IdConjuntogeracaominimaNavigation { get; set; } = null!;

    public virtual DiasSemana IdDiasemanaNavigation { get; set; } = null!;

    public virtual Patamar IdTppatamarNavigation { get; set; } = null!;
}
