using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ImportacaoPmo
{
    public int IdImportacaopmo { get; set; }

    public int IdTpimportacaopmo { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public bool? FlgProcessando { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public DateTime DinImportacao { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public virtual SemanaOperativa? IdSemanaoperativaNavigation { get; set; }

    public virtual TipoImportacaoPmo IdTpimportacaopmoNavigation { get; set; } = null!;

    public virtual ICollection<ListaResultadoPmo> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmo>();
}
