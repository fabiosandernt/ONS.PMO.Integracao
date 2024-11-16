using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ListaResultadoPmoDto
{
    public int IdListaresultadopmo { get; set; }

    public int? IdOrigemresultadopmo { get; set; }

    public int IdResultadocoletapmo { get; set; }

    public int? IdImportacaopmo { get; set; }

    public virtual ImportacaoPmoDto? IdImportacaopmoNavigation { get; set; }

    public virtual OrigemResultadoPmoDto? IdOrigemresultadopmoNavigation { get; set; }

    public virtual ResultadoColetaPmoDto IdResultadocoletapmoNavigation { get; set; } = null!;

    public virtual ICollection<DadoResultPMODto> TbDadoresultpmos { get; set; } = new List<DadoResultPMODto>();
}
