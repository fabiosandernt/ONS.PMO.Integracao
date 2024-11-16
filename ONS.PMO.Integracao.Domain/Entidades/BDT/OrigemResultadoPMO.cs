using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class OrigemResultadoPMO
{
    public int IdOrigemresultadopmo { get; set; }

    public string NomOrigemresultadopmo { get; set; } = null!;

    public string TipOrigemresultadopmo { get; set; } = null!;

    public string CodOrigemresultadopmo { get; set; } = null!;

    public string? CodOrigemresultadopmopai { get; set; }

    public virtual ICollection<ListaResultadoPMO> TbListaresultadopmos { get; set; } = new List<ListaResultadoPMO>();
}
