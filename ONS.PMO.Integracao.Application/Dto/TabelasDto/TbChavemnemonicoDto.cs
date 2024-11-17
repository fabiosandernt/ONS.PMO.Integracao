using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbChavemnemonicoDto
{
    public int IdMnemonicoblocoac { get; set; }

    public int IdCampochave { get; set; }

    public bool FlgDispmanutencao { get; set; }

    public bool FlgDispexportacao { get; set; }

    public bool FlgGeralinhacomentario { get; set; }

    public virtual TbCampochaveDto IdCampochaveNavigation { get; set; } = null!;

    public virtual TbMnemonicoblocoacDto IdMnemonicoblocoacNavigation { get; set; } = null!;
}
