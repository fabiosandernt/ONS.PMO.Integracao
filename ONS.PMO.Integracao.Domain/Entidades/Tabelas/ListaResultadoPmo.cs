using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ListaResultadoPmo
{
    public int IdListaresultadopmo { get; set; }

    public int? IdOrigemresultadopmo { get; set; }

    public int IdResultadocoletapmo { get; set; }

    public int? IdImportacaopmo { get; set; }

    public virtual ImportacaoPmo? IdImportacaopmoNavigation { get; set; }

    public virtual OrigemResultadoPmo? IdOrigemresultadopmoNavigation { get; set; }

    public virtual ResultadoColetaPmo IdResultadocoletapmoNavigation { get; set; } = null!;
    public virtual TbAuxUsinamontador TbAuxUsinamontador { get; set; } = null!;

    public virtual ICollection<DadoResultadoPMO> TbDadoresultpmos { get; set; } = new List<DadoResultadoPMO>();
}
