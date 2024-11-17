using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRestricaoestudoDto
{
    public int IdTprestricao { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadorestricaoestudomontador { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual TbEstadorestricaoestudomontadorDto IdEstadorestricaoestudomontadorNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbTprestricaoDto IdTprestricaoNavigation { get; set; } = null!;

    public virtual ICollection<TbRestricaoDto> TbRestricaos { get; set; } = new List<TbRestricaoDto>();
}
