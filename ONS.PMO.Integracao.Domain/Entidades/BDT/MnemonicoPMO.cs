using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class MnemonicoPMO
{
    public int IdMnemonicopmo { get; set; }

    public int? IdResultadocoletapmo { get; set; }

    public int? IdTpperiodomontador { get; set; }

    public int? IdTpdadograndeza { get; set; }

    public bool? FlgAtivo { get; set; }

    public bool? FlgColetamediapatamares { get; set; }

    public bool? FlgColetapatamar { get; set; }

    public bool? FlgColetasubsistema { get; set; }

    public bool? FlgColetausina { get; set; }

    public string? CodMnemonicopmo { get; set; }

    public string? NomMnemonicopmo { get; set; }

    public int? QtdCasasdecimaisvalor { get; set; }

    public int? QtdDigitosvalor { get; set; }

    public bool? FlgAceitavalornegativo { get; set; }

    public bool? FlgColetareservatorio { get; set; }

    public virtual ResultadoColetaPMO? IdResultadocoletapmoNavigation { get; set; }

    public virtual DadoGrandeza? IdTpdadograndezaNavigation { get; set; }

    public virtual PeriodoMontador? IdTpperiodomontadorNavigation { get; set; }

    public virtual ICollection<DadoResultPMO> TbDadoresultpmos { get; set; } = new List<DadoResultPMO>();
}
