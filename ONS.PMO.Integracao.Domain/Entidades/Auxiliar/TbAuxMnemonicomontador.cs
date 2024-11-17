using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxMnemonicomontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomMnemonico { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxUsinamnemonico> TbAuxUsinamnemonicos { get; set; } = new List<TbAuxUsinamnemonico>();
}
