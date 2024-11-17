using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpestagioDto
{
    public int IdTpestagio { get; set; }

    public string DscTpestagio { get; set; } = null!;

    public virtual ICollection<TbBlocoDto> TbBlocos { get; set; } = new List<TbBlocoDto>();
}
