using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTplimiteDto
{
    public int IdTplimite { get; set; }

    public string DscTplimite { get; set; } = null!;

    public virtual ICollection<TbColunagrandezaDto> TbColunagrandezas { get; set; } = new List<TbColunagrandezaDto>();

    public virtual ICollection<TbDadocoletaestruturadoDto> TbDadocoletaestruturados { get; set; } = new List<TbDadocoletaestruturadoDto>();
}
