using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class OrigemResultadoPmo
{
    public int IdOrigemresultadopmo { get; set; }

    public string NomOrigemresultadopmo { get; set; } = null!;

    public string TipOrigemresultadopmo { get; set; } = null!;

    public string CodOrigemresultadopmo { get; set; } = null!;

    public string? CodOrigemresultadopmopai { get; set; }

    public virtual ICollection<ListaResultadoPmo> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmo>();
}
