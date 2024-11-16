using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxUsinaMnemonicoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdOrigemcoletamnemonico { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public virtual AuxMnemonicoMontadorDto IdOrigemcoletamnemonicoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontadorDto IdOrigemcoletausinaNavigation { get; set; } = null!;
}
