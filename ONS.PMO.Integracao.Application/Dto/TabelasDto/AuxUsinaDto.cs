using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxUsinaDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public string CodTpgeracao { get; set; } = null!;

    public int CodDpp { get; set; }

    public string? NomLongo { get; set; }

    public string? NomCurto { get; set; }

    public string? CodSubmercado { get; set; }

    public virtual OrigemColetumDto IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual ICollection<AuxUnidadeGeradoraDto> TbAuxUnidadegeradoras { get; set; } = new List<AuxUnidadeGeradoraDto>();
}
