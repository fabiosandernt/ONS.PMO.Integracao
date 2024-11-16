using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RecuperacaoDadoDto
{
    public int IdRecuperacaodados { get; set; }

    public int? IdEstudomontadorfonte { get; set; }

    public string? NomArquivofonte { get; set; }

    public int? IdSemanaoperativafonte { get; set; }

    public bool FlgInserirchaves { get; set; }

    public int IdEstudomontadordestino { get; set; }

    public string LgnUsuario { get; set; } = null!;

    public DateTime DinRecuperacao { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadordestinoNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto? IdEstudomontadorfonteNavigation { get; set; }

    public virtual SemanaOperativaDto? IdSemanaoperativafonteNavigation { get; set; }

    public virtual ICollection<RecuperacaoDadosAgentePmoDto> TbRecuperacaodadosagentepmos { get; set; } = new List<RecuperacaoDadosAgentePmoDto>();

    public virtual ICollection<RecuperacaoDadosBlocoDto> TbRecuperacaodadosblocos { get; set; } = new List<RecuperacaoDadosBlocoDto>();
}
