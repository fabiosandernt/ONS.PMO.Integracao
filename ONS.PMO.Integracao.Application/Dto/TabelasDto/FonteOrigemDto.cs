using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class FonteOrigemDto
{
    public int IdFonteorigem { get; set; }

    public string NomFonteorigem { get; set; } = null!;

    public bool FlgEletrica { get; set; }

    public bool FlgHidraulica { get; set; }

    public virtual ICollection<RestricaoDto> TbRestricaos { get; set; } = new List<RestricaoDto>();
}
