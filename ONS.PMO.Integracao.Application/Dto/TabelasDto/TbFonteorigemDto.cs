using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbFonteorigemDto
{
    public int IdFonteorigem { get; set; }

    public string NomFonteorigem { get; set; } = null!;

    public bool FlgEletrica { get; set; }

    public bool FlgHidraulica { get; set; }

    public virtual ICollection<TbRestricaoDto> TbRestricaos { get; set; } = new List<TbRestricaoDto>();
}
