using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class EstagioGrandezaMnemonico
{
    public int IdEstagiograndezamnemonico { get; set; }

    public int IdGrandezamnemonicoestudo { get; set; }

    public DateOnly DatIniciosemana { get; set; }

    public DateOnly DatFimsemana { get; set; }

    public int? NumIndice { get; set; }

    public virtual GrandezaMnemonicoEstudo IdGrandezamnemonicoestudoNavigation { get; set; } = null!;
}
