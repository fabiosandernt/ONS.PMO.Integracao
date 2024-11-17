using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDadoresultpmoDto
{
    public int IdDadoresultpmo { get; set; }

    public int IdMnemonicopmo { get; set; }

    public int IdListaresultadopmo { get; set; }

    public int? IdTppatamar { get; set; }

    public string DscValorcoletadomnemonico { get; set; } = null!;

    public bool? FlgValoroficial { get; set; }

    public int? NumEstagio { get; set; }

    public virtual TbListaresultadopmoDto IdListaresultadopmoNavigation { get; set; } = null!;

    public virtual TbMnemonicopmoDto IdMnemonicopmoNavigation { get; set; } = null!;
}
