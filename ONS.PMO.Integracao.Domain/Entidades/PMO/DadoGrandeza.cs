using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoGrandeza
{
    public int IdTpdadograndeza { get; set; }

    public string DscTpdadograndeza { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<GrandezaMontador> TbGrandezamontadors { get; set; } = new List<GrandezaMontador>();

    public virtual ICollection<Grandeza> TbGrandezas { get; set; } = new List<Grandeza>();

    public virtual ICollection<MnemonicoPmo> TbMnemonicopmos { get; set; } = new List<MnemonicoPmo>();
}
