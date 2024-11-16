using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaMnemonicoEstudoDto
{
    public int IdGrandezamnemonicoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdEstudomontador { get; set; }

    public string ValGrandezamnemonicoestudo { get; set; } = null!;

    public string? FlgFonte { get; set; }

    public int? IdMotivoalteracao { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual GrandezaBlocoAcDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual MotivoAlteracaoDto? IdMotivoalteracaoNavigation { get; set; }

    public virtual OrigemColetaMontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual ICollection<EstagioGrandezaMnemonicoDto> TbEstagiograndezamnemonicos { get; set; } = new List<EstagioGrandezaMnemonicoDto>();
}
