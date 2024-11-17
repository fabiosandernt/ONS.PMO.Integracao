using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGrandezamnemonicoestudoDto
{
    public int IdGrandezamnemonicoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdEstudomontador { get; set; }

    public string ValGrandezamnemonicoestudo { get; set; } = null!;

    public string? FlgFonte { get; set; }

    public int? IdMotivoalteracao { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbGrandezablocoacDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual TbMotivoalteracaoDto? IdMotivoalteracaoNavigation { get; set; }

    public virtual TbOrigemcoletamontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual ICollection<TbEstagiograndezamnemonicoDto> TbEstagiograndezamnemonicos { get; set; } = new List<TbEstagiograndezamnemonicoDto>();
}
