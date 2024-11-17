using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbArquivofonteresultpmoDto
{
    public int IdArquivofonteresultpmo { get; set; }

    public string NomArquivofonteresultpmo { get; set; } = null!;

    public virtual ICollection<TbResultadocoletapmoDto> TbResultadocoletapmos { get; set; } = new List<TbResultadocoletapmoDto>();
}
