using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class MnemonicoPmoDto
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

    public virtual ResultadoColetaPmoDto? IdResultadocoletapmoNavigation { get; set; }

    public virtual DadoGrandezaDto? IdTpdadograndezaNavigation { get; set; }

    public virtual PeriodoMontadorDto? IdTpperiodomontadorNavigation { get; set; }

    public virtual ICollection<DadoResultPMODto> TbDadoresultpmos { get; set; } = new List<DadoResultPMODto>();
}
