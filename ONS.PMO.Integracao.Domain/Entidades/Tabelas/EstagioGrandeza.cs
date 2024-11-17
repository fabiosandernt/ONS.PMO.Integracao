using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class EstagioGrandeza
{
    public int IdEstagiograndeza { get; set; }

    public int IdGrandezablocoestudo { get; set; }

    public DateOnly DatIniciosemana { get; set; }

    public DateOnly DatFimsemana { get; set; }

    public virtual GrandezaBlocoEstudo IdGrandezablocoestudoNavigation { get; set; } = null!;
}
