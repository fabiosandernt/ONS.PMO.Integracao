using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ModConfigBlocoEstudo
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdBloco { get; set; }

    public int NumRevisao { get; set; }

    public string NomCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual Bloco? IdBlocoNavigation { get; set; }

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual HistoricoConfiguracaoBloco? TbHisconfigbloco { get; set; }

    public virtual ICollection<HistoricoConfiguracaoGrandeza> TbHisconfiggrandezas { get; set; } = new List<HistoricoConfiguracaoGrandeza>();

    public virtual ICollection<CampoChave> IdCampochaves { get; set; } = new List<CampoChave>();

    public virtual ICollection<ColunaGrandeza> IdColunagrandezas { get; set; } = new List<ColunaGrandeza>();
}
