using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbListaresultadopmoDto
{
    public int IdListaresultadopmo { get; set; }

    public int? IdOrigemresultadopmo { get; set; }

    public int IdResultadocoletapmo { get; set; }

    public int? IdImportacaopmo { get; set; }

    public virtual TbImportacaopmoDto? IdImportacaopmoNavigation { get; set; }

    public virtual TbOrigemresultadopmoDto? IdOrigemresultadopmoNavigation { get; set; }

    public virtual TbResultadocoletapmoDto IdResultadocoletapmoNavigation { get; set; } = null!;

    public virtual ICollection<TbDadoresultpmoDto> TbDadoresultpmos { get; set; } = new List<TbDadoresultpmoDto>();
}
