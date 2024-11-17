using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGrandezablocoestudoDto
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

    public virtual TbColunagrandezaDto IdColunagrandezaNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual TbRestricaoDto? IdRestricaoNavigation { get; set; }

    public virtual ICollection<TbEstagiograndezaDto> TbEstagiograndezas { get; set; } = new List<TbEstagiograndezaDto>();
}
