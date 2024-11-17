using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbBlocoestudomontadorDto
{
    public int IdBlocoestudomontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadoblocoestudomontador { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual TbBlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual TbEstadoblocoestudomontadorDto IdEstadoblocoestudomontadorNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
