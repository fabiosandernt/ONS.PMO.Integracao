using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbImportacaopmoDto
{
    public int IdImportacaopmo { get; set; }

    public int IdTpimportacaopmo { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public bool? FlgProcessando { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public DateTime DinImportacao { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public virtual TbSemanaoperativaDto? IdSemanaoperativaNavigation { get; set; }

    public virtual TbTpimportacaopmoDto IdTpimportacaopmoNavigation { get; set; } = null!;

    public virtual ICollection<TbListaresultadopmoDto> TbListaresultadopmos { get; set; } = new List<TbListaresultadopmoDto>();
}
