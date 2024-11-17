using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ResultadoColetaPmo
{
    public int IdResultadocoletapmo { get; set; }

    public int? IdArquivofonteresultpmo { get; set; }

    public string? NomResultadocoletapmo { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? ObsResultadocoletapmo { get; set; }

    public virtual ArquivoFonteResultadoPmo? IdArquivofonteresultpmoNavigation { get; set; }

    public virtual ICollection<ListaResultadoPmo> TbListaresultadopmos { get; set; } = new List<ListaResultadoPmo>();

    public virtual ICollection<MnemonicoPmo> TbMnemonicopmos { get; set; } = new List<MnemonicoPmo>();
}
