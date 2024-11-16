using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LimiteDto
{
    public int IdTplimite { get; set; }

    public string DscTplimite { get; set; } = null!;

    public virtual ICollection<ColunaGrandezaDto> TbColunagrandezas { get; set; } = new List<ColunaGrandezaDto>();

    public virtual ICollection<DadoColetaEstruturadoDto> TbDadocoletaestruturados { get; set; } = new List<DadoColetaEstruturadoDto>();
}
