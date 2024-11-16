using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoColeta
{
    public int IdDadocoleta { get; set; }

    public string TipDadocoleta { get; set; } = null!;

    public int? IdGrandeza { get; set; }

    public int IdGabarito { get; set; }

    public int IdColetainsumo { get; set; }

    public virtual ColetaInsumo IdColetainsumoNavigation { get; set; } = null!;

    public virtual Gabarito IdGabaritoNavigation { get; set; } = null!;

    public virtual Grandeza? IdGrandezaNavigation { get; set; }

    public virtual DadoColetaEstruturado? TbDadocoletaestruturado { get; set; }

    public virtual DadoColetaManutencao? TbDadocoletamanutencao { get; set; }

    public virtual DadoColetaNaoEstruturado? TbDadocoletanaoestruturado { get; set; }
}
