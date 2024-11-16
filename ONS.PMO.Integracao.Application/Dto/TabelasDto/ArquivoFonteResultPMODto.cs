using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ArquivoFonteResultPMODto
{
    public int IdArquivofonteresultpmo { get; set; }

    public string NomArquivofonteresultpmo { get; set; } = null!;

    public virtual ICollection<ResultadoColetaPmoDto> TbResultadocoletapmos { get; set; } = new List<ResultadoColetaPmoDto>();
}
