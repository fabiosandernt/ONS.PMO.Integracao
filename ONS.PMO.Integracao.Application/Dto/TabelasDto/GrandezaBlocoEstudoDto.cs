using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaBlocoEstudoDto
{
    public int IdGrandezablocoestudo { get; set; }

    public int IdColunagrandeza { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdRestricao { get; set; }

    public string ValGrandezablocoestudo { get; set; } = null!;

    public string? FlgFonte { get; set; }

    public bool? FlgNormalizado { get; set; }

    public string? ValGrandezablocoestudooriginal { get; set; }

    public virtual ColunaGrandezaDto IdColunagrandezaNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual OrigemColetaMontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual RestricaoDto? IdRestricaoNavigation { get; set; }

    public virtual ICollection<EstagioGrandezaDto> TbEstagiograndezas { get; set; } = new List<EstagioGrandezaDto>();
}
