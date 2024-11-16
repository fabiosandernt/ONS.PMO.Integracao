using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class BlocoEstudoMontadorDto
{
    public int IdBlocoestudomontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadoblocoestudomontador { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual BlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual EstadoBlocoEstudoMontadorDto IdEstadoblocoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
