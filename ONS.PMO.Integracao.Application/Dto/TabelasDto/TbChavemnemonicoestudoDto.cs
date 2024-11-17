using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbChavemnemonicoestudoDto
{
    public int IdChavemnemonicoestudo { get; set; }

    public int IdOrigemcoletamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int IdEstudomontador { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbMnemonicoblocoacDto IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
