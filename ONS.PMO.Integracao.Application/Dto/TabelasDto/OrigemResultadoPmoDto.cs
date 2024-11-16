using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class OrigemResultadoPmoDto
{
    public int IdOrigemresultadopmo { get; set; }

    public string NomOrigemresultadopmo { get; set; } = null!;

    public string TipOrigemresultadopmo { get; set; } = null!;

    public string CodOrigemresultadopmo { get; set; } = null!;

    public string? CodOrigemresultadopmopai { get; set; }

    public virtual ICollection<ListaResultadoPmoDto> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmoDto>();
}
