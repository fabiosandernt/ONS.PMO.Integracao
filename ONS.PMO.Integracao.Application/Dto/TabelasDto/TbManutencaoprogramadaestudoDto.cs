using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbManutencaoprogramadaestudoDto
{
    public int IdEstudomontador { get; set; }

    public string? LgnUsuariocheckout { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
