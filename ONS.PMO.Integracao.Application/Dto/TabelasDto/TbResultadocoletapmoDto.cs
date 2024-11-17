using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbResultadocoletapmoDto
{
    public int IdResultadocoletapmo { get; set; }

    public int? IdArquivofonteresultpmo { get; set; }

    public string? NomResultadocoletapmo { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? ObsResultadocoletapmo { get; set; }

    public virtual TbArquivofonteresultpmoDto? IdArquivofonteresultpmoNavigation { get; set; }

    public virtual ICollection<TbListaresultadopmoDto> TbListaresultadopmos { get; set; } = new List<TbListaresultadopmoDto>();

    public virtual ICollection<TbMnemonicopmoDto> TbMnemonicopmos { get; set; } = new List<TbMnemonicopmoDto>();
}
