using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUsinaDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public string CodTpgeracao { get; set; } = null!;

    public int CodDpp { get; set; }

    public string? NomLongo { get; set; }

    public string? NomCurto { get; set; }

    public string? CodSubmercado { get; set; }

    public virtual TbOrigemcoletumDto IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxUnidadegeradoraDto> TbAuxUnidadegeradoras { get; set; } = new List<TbAuxUnidadegeradoraDto>();
}
