using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGrandezaDto
{
    public int IdGrandeza { get; set; }

    public int IdInsumopmo { get; set; }

    public string NomGrandeza { get; set; } = null!;

    public short NumOrdemexibicao { get; set; }

    public bool FlgColetaporpatamar { get; set; }

    public bool FlgColetaporlimite { get; set; }

    public bool FlgColetaporestagio { get; set; }

    public bool FlgAceitavalornegativo { get; set; }

    public bool FlgPoderecuperarvalor { get; set; }

    public bool FlgDestacadiferenca { get; set; }

    public bool FlgAtivo { get; set; }

    public int IdTpdadograndeza { get; set; }

    public int? QtdDigitos { get; set; }

    public int? QtdDecimais { get; set; }

    public bool? FlgParticipablocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public bool? FlgObrigatoriedade { get; set; }

    public bool FlgPreaprovadocomalteracao { get; set; }

    public virtual TbInsumoestruturadoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual TbTpdadograndezaDto IdTpdadograndezaNavigation { get; set; } = null!;

    public virtual ICollection<TbDadocoletumDto> TbDadocoleta { get; set; } = new List<TbDadocoletumDto>();

    public virtual ICollection<TbGrandezablocoDto> TbGrandezablocos { get; set; } = new List<TbGrandezablocoDto>();
}
