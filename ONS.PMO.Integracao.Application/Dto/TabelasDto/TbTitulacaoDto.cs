using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTitulacaoDto
{
    public int IdTitulacao { get; set; }

    public string NomTitulacao { get; set; } = null!;

    public string CodTitulacao { get; set; } = null!;

    public virtual ICollection<TbDecisaocomandognlDto> TbDecisaocomandognls { get; set; } = new List<TbDecisaocomandognlDto>();
}
