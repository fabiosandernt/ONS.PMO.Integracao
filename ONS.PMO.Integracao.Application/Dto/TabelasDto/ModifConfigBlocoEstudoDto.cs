using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ModifConfigBlocoEstudoDto
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdBloco { get; set; }

    public int NumRevisao { get; set; }

    public string NomCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual BlocoDto? IdBlocoNavigation { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual HisConfigBlocoDto? TbHisconfigbloco { get; set; }

    public virtual ICollection<HisConfigGrandezaDto> TbHisconfiggrandezas { get; set; } = new List<HisConfigGrandezaDto>();

    public virtual ICollection<CampoChaveDto> IdCampochaves { get; set; } = new List<CampoChaveDto>();

    public virtual ICollection<ColunaGrandezaDto> IdColunagrandezas { get; set; } = new List<ColunaGrandezaDto>();
}
