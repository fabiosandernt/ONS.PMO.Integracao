using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ChaveMnemonicoEstudoDto
{
    public int IdChavemnemonicoestudo { get; set; }

    public int IdOrigemcoletamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int IdEstudomontador { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAcDto IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
