using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Coleta
{
    public int IdTpcoleta { get; set; }

    public string DscTpcoleta { get; set; } = null!;

    public bool FlgBlocomontador { get; set; }

    public bool FlgPmo { get; set; }

    public bool FlgMnemonicomontador { get; set; }

    public virtual ICollection<Bloco> TbBlocos { get; set; } = new List<Bloco>();

    public virtual ICollection<CampoChaveColeta> TbCampochavetpcoleta { get; set; } = new List<CampoChaveColeta>();

    public virtual ICollection<InsumoEstruturado> TbInsumoestruturados { get; set; } = new List<InsumoEstruturado>();

    public virtual ICollection<MnemonicoBlocoAC> TbMnemonicoblocoacs { get; set; } = new List<MnemonicoBlocoAC>();

    public virtual ICollection<OrigemColetaMontador> TbOrigemcoletamontadors { get; set; } = new List<OrigemColetaMontador>();
}
