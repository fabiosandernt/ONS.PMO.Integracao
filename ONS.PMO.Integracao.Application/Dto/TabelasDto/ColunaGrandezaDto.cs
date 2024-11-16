using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ColunaGrandezaDto
{
    public int IdColunagrandeza { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdTppatamar { get; set; }

    public int? IdTplimite { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual GrandezaBlocoDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual LimiteDto? IdTplimiteNavigation { get; set; }

    public virtual PatamarDto? IdTppatamarNavigation { get; set; }

    public virtual ICollection<GrandezaBlocoEstudoDto> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudoDto>();

    public virtual ICollection<ModifConfigBlocoEstudoDto> IdModifconfigblocoestudos { get; set; } = new List<ModifConfigBlocoEstudoDto>();
}
