using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RestricaoEstudoDto
{
    public int IdTprestricao { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadorestricaoestudomontador { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual EstadoRestricaoEstudoMontadorDto IdEstadorestricaoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual PrestricaoDto IdTprestricaoNavigation { get; set; } = null!;

    public virtual ICollection<RestricaoDto> TbRestricaos { get; set; } = new List<RestricaoDto>();
}
