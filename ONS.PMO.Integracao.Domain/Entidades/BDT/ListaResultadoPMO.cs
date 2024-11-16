using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class ListaResultadoPMO
{
    public int IdListaresultadopmo { get; set; }

    public int? IdOrigemresultadopmo { get; set; }

    public int IdResultadocoletapmo { get; set; }

    public int? IdImportacaopmo { get; set; }

    public virtual ImportacaoPMO? IdImportacaopmoNavigation { get; set; }

    public virtual OrigemResultadoPMO? IdOrigemresultadopmoNavigation { get; set; }

    public virtual ResultadoColetaPMO IdResultadocoletapmoNavigation { get; set; } = null!;
    public virtual AuxUsinaMontador TbAuxUsinamontador { get; set; } = null!;

    public virtual ICollection<DadoResultPMO> TbDadoresultpmos { get; set; } = new List<DadoResultPMO>();
}
