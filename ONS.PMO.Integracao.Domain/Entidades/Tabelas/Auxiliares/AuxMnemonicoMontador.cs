using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxMnemonicoMontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomMnemonico { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxUsinaMnemonico> TbAuxUsinamnemonicos { get; set; } = new List<AuxUsinaMnemonico>();
}
