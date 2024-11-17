using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDadocoletanaoestruturadoDto
{
    public int IdDadocoleta { get; set; }

    public string? ObsDadocoletanaoestruturado { get; set; }

    public virtual TbDadocoletumDto IdDadocoletaNavigation { get; set; } = null!;

    public virtual ICollection<TbArquivoDto> IdArquivos { get; set; } = new List<TbArquivoDto>();
}
