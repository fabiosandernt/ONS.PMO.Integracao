using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class OrigemColetum
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string TipOrigemcoleta { get; set; } = null!;

    public string NomExibicao { get; set; } = null!;

    public virtual TbAuxReservatorio? TbAuxReservatorio { get; set; }

    public virtual TbAuxSubsistema? TbAuxSubsistema { get; set; }

    public virtual TbAuxUnidadegeradora? TbAuxUnidadegeradora { get; set; }

    public virtual TbAuxUsina? TbAuxUsina { get; set; }

    public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();
}
