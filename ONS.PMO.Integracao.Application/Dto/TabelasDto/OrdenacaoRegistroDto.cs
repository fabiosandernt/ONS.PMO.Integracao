using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class OrdenacaoRegistroDto
{
    public int IdOrdenacaoregistros { get; set; }

    public int IdBloco { get; set; }

    public int NumOrdenacao { get; set; }

    public int? IdCampochave { get; set; }

    public int? IdGrandezamontador { get; set; }

    public string FlgTpordenacao { get; set; } = null!;

    public int NumRevisao { get; set; }

    public virtual BlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual CampoChaveDto? IdCampochaveNavigation { get; set; }

    public virtual GrandezaBlocoDto? IdGrandezamontadorNavigation { get; set; }
}
