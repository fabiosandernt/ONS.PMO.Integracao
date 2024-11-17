using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRestricaoDto
{
    public int IdRestricao { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdTprestricao { get; set; }

    public int IdFonteorigem { get; set; }

    public int? NumRestricao { get; set; }

    public int? NumRestricaoestudoanterior { get; set; }

    public string CodIdentificador { get; set; } = null!;

    public string? DscComentario { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public bool FlgImportado { get; set; }

    public DateTime DinEstagioinicial { get; set; }

    public DateTime DinEstagiofinal { get; set; }

    public int? IdRestricaopai { get; set; }

    public virtual TbFonteorigemDto IdFonteorigemNavigation { get; set; } = null!;

    public virtual TbRestricaoDto? IdRestricaopaiNavigation { get; set; }

    public virtual ICollection<TbRestricaoDto> InverseIdRestricaopaiNavigation { get; set; } = new List<TbRestricaoDto>();

    public virtual ICollection<TbChaveblocoestudoDto> TbChaveblocoestudos { get; set; } = new List<TbChaveblocoestudoDto>();

    public virtual ICollection<TbGrandezablocoestudoDto> TbGrandezablocoestudos { get; set; } = new List<TbGrandezablocoestudoDto>();

    public virtual TbRestricaoeletricaDto? TbRestricaoeletrica { get; set; }

    public virtual TbRestricaoestudoDto TbRestricaoestudo { get; set; } = null!;
}
