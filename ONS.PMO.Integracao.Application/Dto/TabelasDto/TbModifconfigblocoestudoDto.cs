using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbModifconfigblocoestudoDto
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdBloco { get; set; }

    public int NumRevisao { get; set; }

    public string NomCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual TbBlocoDto? IdBlocoNavigation { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbHisconfigblocoDto? TbHisconfigbloco { get; set; }

    public virtual ICollection<TbHisconfiggrandezaDto> TbHisconfiggrandezas { get; set; } = new List<TbHisconfiggrandezaDto>();

    public virtual ICollection<TbCampochaveDto> IdCampochaves { get; set; } = new List<TbCampochaveDto>();

    public virtual ICollection<TbColunagrandezaDto> IdColunagrandezas { get; set; } = new List<TbColunagrandezaDto>();
}
