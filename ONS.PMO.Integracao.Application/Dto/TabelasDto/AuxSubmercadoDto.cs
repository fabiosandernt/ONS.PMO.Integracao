using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxSubmercadoDto
{
    public string CodSubmercado { get; set; } = null!;

    public int IdOrigemcoletamontador { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
