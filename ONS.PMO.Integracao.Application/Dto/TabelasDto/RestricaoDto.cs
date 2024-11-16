using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RestricaoDto
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

    public virtual FonteOrigemDto IdFonteorigemNavigation { get; set; } = null!;

    public virtual RestricaoDto? IdRestricaopaiNavigation { get; set; }

    public virtual ICollection<RestricaoDto> InverseIdRestricaopaiNavigation { get; set; } = new List<RestricaoDto>();

    public virtual ICollection<ChaveBlocoEstudoDto> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudoDto>();

    public virtual ICollection<GrandezaBlocoEstudoDto> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudoDto>();

    public virtual RestricaoEletricaDto? TbRestricaoeletrica { get; set; }

    public virtual RestricaoEstudoDto TbRestricaoestudo { get; set; } = null!;
}
