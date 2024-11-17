using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbColunagrandezaDto
{
    public int IdColunagrandeza { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdTppatamar { get; set; }

    public int? IdTplimite { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual TbGrandezablocoDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual TbTplimiteDto? IdTplimiteNavigation { get; set; }

    public virtual TbTppatamarDto? IdTppatamarNavigation { get; set; }

    public virtual ICollection<TbGrandezablocoestudoDto> TbGrandezablocoestudos { get; set; } = new List<TbGrandezablocoestudoDto>();

    public virtual ICollection<TbModifconfigblocoestudoDto> IdModifconfigblocoestudos { get; set; } = new List<TbModifconfigblocoestudoDto>();
}
