using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Application.Dto.PMO;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRecuperacaodadoDto
{
    public int IdRecuperacaodados { get; set; }

    public int? IdEstudomontadorfonte { get; set; }

    public string? NomArquivofonte { get; set; }

    public int? IdSemanaoperativafonte { get; set; }

    public bool FlgInserirchaves { get; set; }

    public int IdEstudomontadordestino { get; set; }

    public string LgnUsuario { get; set; } = null!;

    public DateTime DinRecuperacao { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadordestinoNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto? IdEstudomontadorfonteNavigation { get; set; }

    public virtual TbSemanaoperativaDto? IdSemanaoperativafonteNavigation { get; set; }

    public virtual ICollection<TbRecuperacaodadosagentepmoDto> TbRecuperacaodadosagentepmos { get; set; } = new List<TbRecuperacaodadosagentepmoDto>();

    public virtual ICollection<TbRecuperacaodadosblocoDto> TbRecuperacaodadosblocos { get; set; } = new List<TbRecuperacaodadosblocoDto>();
}
