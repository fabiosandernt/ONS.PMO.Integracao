using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ResultadoColetaPmoDto
{
    public int IdResultadocoletapmo { get; set; }

    public int? IdArquivofonteresultpmo { get; set; }

    public string? NomResultadocoletapmo { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? ObsResultadocoletapmo { get; set; }

    public virtual ArquivoFonteResultPMODto? IdArquivofonteresultpmoNavigation { get; set; }

    public virtual ICollection<ListaResultadoPmoDto> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmoDto>();

    public virtual ICollection<MnemonicoPmoDto> TbMnemonicopmos { get; set; } = new List<MnemonicoPmoDto>();
}
