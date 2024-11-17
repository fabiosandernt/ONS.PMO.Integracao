using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGeracaominimaperiododiumDto
{
    public int IdGeracaominimaperiododia { get; set; }

    public int IdConjuntogeracaominima { get; set; }

    public int IdTppatamar { get; set; }

    public int IdDiasemana { get; set; }

    public TimeOnly HorInicial { get; set; }

    public TimeOnly HorFinal { get; set; }

    public double ValGeracaominimaperiododia { get; set; }

    public virtual TbConjuntogeracaominimaDto IdConjuntogeracaominimaNavigation { get; set; } = null!;

    public virtual TbDiasemanaDto IdDiasemanaNavigation { get; set; } = null!;

    public virtual TbTppatamarDto IdTppatamarNavigation { get; set; } = null!;
}
