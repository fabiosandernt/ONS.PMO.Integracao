using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGrandezablocoacDto
{
    public int IdGrandezamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual TbGrandezamontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual TbMnemonicoblocoacDto IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual ICollection<TbGrandezamnemonicoestudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<TbGrandezamnemonicoestudoDto>();

    public virtual ICollection<TbGrandezablocoacDto> IdGrandezamontadordependentes { get; set; } = new List<TbGrandezablocoacDto>();

    public virtual ICollection<TbGrandezablocoacDto> IdGrandezamontadors { get; set; } = new List<TbGrandezablocoacDto>();
}
