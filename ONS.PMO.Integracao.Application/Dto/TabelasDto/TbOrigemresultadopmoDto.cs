using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbOrigemresultadopmoDto
{
    public int IdOrigemresultadopmo { get; set; }

    public string NomOrigemresultadopmo { get; set; } = null!;

    public string TipOrigemresultadopmo { get; set; } = null!;

    public string CodOrigemresultadopmo { get; set; } = null!;

    public string? CodOrigemresultadopmopai { get; set; }

    public virtual ICollection<TbListaresultadopmoDto> TbListaresultadopmos { get; set; } = new List<TbListaresultadopmoDto>();
}
