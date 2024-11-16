using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class ImportacaoPMO
{
    public int IdImportacaopmo { get; set; }

    public int IdTpimportacaopmo { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public bool? FlgProcessando { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public DateTime DinImportacao { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public virtual SemanaOperativa? IdSemanaoperativaNavigation { get; set; }

    public virtual TipoImportacaoPMO IdTpimportacaopmoNavigation { get; set; } = null!;

    public virtual ICollection<ListaResultadoPMO> TbListaresultadopmos { get; set; } = new List<ListaResultadoPMO>();
}
