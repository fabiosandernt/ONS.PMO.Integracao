using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ImportacaoPmoDto
{
    public int IdImportacaopmo { get; set; }

    public int IdTpimportacaopmo { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public bool? FlgProcessando { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public DateTime DinImportacao { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public virtual SemanaOperativaDto? IdSemanaoperativaNavigation { get; set; }

    public virtual ImportacaoDto IdTpimportacaopmoNavigation { get; set; } = null!;

    public virtual ICollection<ListaResultadoPmoDto> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmoDto>();
}
