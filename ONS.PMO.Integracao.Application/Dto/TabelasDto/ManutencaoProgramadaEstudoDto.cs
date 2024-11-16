using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ManutencaoProgramadaEstudoDto
{
    public int IdEstudomontador { get; set; }

    public string? LgnUsuariocheckout { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
