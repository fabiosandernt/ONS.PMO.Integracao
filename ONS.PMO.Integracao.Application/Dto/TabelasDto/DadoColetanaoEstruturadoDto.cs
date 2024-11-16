using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DadoColetanaoEstruturadoDto
{
    public int IdDadocoleta { get; set; }

    public string? ObsDadocoletanaoestruturado { get; set; }

    public virtual DadoColetumDto IdDadocoletaNavigation { get; set; } = null!;

    public virtual ICollection<ArquivoDto> IdArquivos { get; set; } = new List<ArquivoDto>();
}
