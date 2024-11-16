using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GeracaoMinimaPeriodoDto
{
    public int IdGeracaominimaperiododia { get; set; }

    public int IdConjuntogeracaominima { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValGeracaominimaperiododia { get; set; }

    public virtual ConjuntoGeracaoMinimaDto IdConjuntogeracaominimaNavigation { get; set; } = null!;

    public virtual DiaSemanaDto IdDiasemanaNavigation { get; set; } = null!;

    public virtual PatamarDto IdTppatamarNavigation { get; set; } = null!;
}
