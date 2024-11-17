using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDesligamentoDto
{
    public int IdDesligamento { get; set; }

    public int IdConjuntogeracaominima { get; set; }

    public string DscMotivo { get; set; } = null!;

    public string TpDesligamento { get; set; } = null!;

    public DateTime DinInicio { get; set; }

    public DateTime DinFim { get; set; }

    public double ValGeracaominima { get; set; }

    public long? NumIntervencaosgi { get; set; }

    public virtual TbConjuntogeracaominimaDto IdConjuntogeracaominimaNavigation { get; set; } = null!;
}
