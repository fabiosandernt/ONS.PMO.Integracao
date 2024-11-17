using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpperiodomontadorDto
{
    public int IdTpperiodomontador { get; set; }

    public string NomTpperiodomontador { get; set; } = null!;

    public virtual ICollection<TbMnemonicopmoDto> TbMnemonicopmos { get; set; } = new List<TbMnemonicopmoDto>();
}
