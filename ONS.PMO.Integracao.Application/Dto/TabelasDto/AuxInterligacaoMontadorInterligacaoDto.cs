using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxInterligacaoMontadorInterligacaoDto
{
    public int IdInterligacao { get; set; }

    public int IdOrigemcoletainterligacao { get; set; }

    public bool FlgSoma { get; set; }

    public virtual AuxInterligacaoDto IdInterligacaoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletainterligacaoNavigation { get; set; } = null!;
}
