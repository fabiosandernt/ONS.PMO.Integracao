using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaBlocoAcDto
{
    public int IdGrandezamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual GrandezaMontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAcDto IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual ICollection<GrandezaMnemonicoEstudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudoDto>();

    public virtual ICollection<GrandezaBlocoAcDto> IdGrandezamontadordependentes { get; set; } = new List<GrandezaBlocoAcDto>();

    public virtual ICollection<GrandezaBlocoAcDto> IdGrandezamontadors { get; set; } = new List<GrandezaBlocoAcDto>();
}
