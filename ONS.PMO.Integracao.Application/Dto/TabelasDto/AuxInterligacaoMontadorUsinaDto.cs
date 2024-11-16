using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxInterligacaoMontadorUsinaDto
{
    public int IdOrigemcoletainterligprinc { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public bool FlgSoma { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletainterligprincNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletausinaNavigation { get; set; } = null!;
}
