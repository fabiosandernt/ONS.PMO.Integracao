using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class OrigemColetum
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string TipOrigemcoleta { get; set; } = null!;

    public string NomExibicao { get; set; } = null!;

    public virtual AuxReservatorio? TbAuxReservatorio { get; set; }

    public virtual AuxSubsistema? TbAuxSubsistema { get; set; }

    public virtual AuxUnidadeGeradora? TbAuxUnidadegeradora { get; set; }

    public virtual AuxUsina? TbAuxUsina { get; set; }

    public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();
}
