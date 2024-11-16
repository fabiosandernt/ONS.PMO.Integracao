using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstagioDto
{
    public int IdTpestagio { get; set; }

    public string DscTpestagio { get; set; } = null!;

    public virtual ICollection<BlocoDto> TbBlocos { get; set; } = new List<BlocoDto>();
}
