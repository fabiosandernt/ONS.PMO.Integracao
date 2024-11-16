using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class ResultadoColetaPMO
{
    public int IdResultadocoletapmo { get; set; }

    public int? IdArquivofonteresultpmo { get; set; }

    public string? NomResultadocoletapmo { get; set; }

    public string NomUsuarioultimaalteracao { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? ObsResultadocoletapmo { get; set; }

    public virtual ArquivoFonteResultPMO? IdArquivofonteresultpmoNavigation { get; set; }

    public virtual ICollection<ListaResultadoPMO> TbListaresultadopmos { get; set; } = new List<ListaResultadoPMO>();

    public virtual ICollection<MnemonicoPMO> TbMnemonicopmos { get; set; } = new List<MnemonicoPMO>();
}
