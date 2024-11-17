using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbOrdenacaoregistroDto
{
    public int IdOrdenacaoregistros { get; set; }

    public int IdBloco { get; set; }

    public int NumOrdenacao { get; set; }

    public int? IdCampochave { get; set; }

    public int? IdGrandezamontador { get; set; }

    public string FlgTpordenacao { get; set; } = null!;

    public int NumRevisao { get; set; }

    public virtual TbBlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual TbCampochaveDto? IdCampochaveNavigation { get; set; }

    public virtual TbGrandezablocoDto? IdGrandezamontadorNavigation { get; set; }
}
